 
--***************************************************************************************************
-- Description :	 입출고테이블에 이뤄지는 작업을 집계함	
--***************************************************************************************************

alter	TRIGGER [dbo].[SEP215_Update] ON [dbo].[SEP215]
FOR INSERT, UPDATE--, DELETE 
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

--사용변수 선언
DECLARE	@file_no			VARCHAR(20),	--이동번호
		@file_sq			INT,			--이동순번
		@qty			DECIMAL(18, 5),	--량
		@mprogclss_bc		VARCHAR(10),		--사용공장
		@dprogclss_bc		VARCHAR(10),		--사용공장
		@blqty			DECIMAL(18, 5),	--량
		@closeqty			DECIMAL(18, 5),	--량		
        @ty                 varchar(10),
        @msg			NVARCHAR(500)

	DECLARE Acur CURSOR FAST_FORWARD LOCAL FOR 

		SELECT	file_no, file_sq, 
				qty, progclss_bc, isnull(blqty,0), closeqty,
				a.ty
		FROM (
				SELECT	file_no, file_sq, 
						qty, progclss_bc, isnull(blqty,0)blqty, closeqty,
						ty = 'i'
				FROM	INSERTED
			) a	
			
        where 1=1 
		order by a.ty


	OPEN Acur
		FETCH NEXT FROM Acur INTO 
			@file_no, @file_sq, @qty, @dprogclss_bc, @blqty, @closeqty,@ty
			
--select @file_no, @file_sq, @qty, @dprogclss_bc, @blqty, @closeqty,@ty
	WHILE @@FETCH_STATUS = 0
	BEGIN

		IF @ty = 'i' 
		BEGIN
            Update A set progclss_bc='SE19030' --b/l진행완료 
            From sep215 A
            Where file_no=@file_no and file_sq=@file_sq
              And (qty-isnull(blqty,0))<=0    --b/l처리완료
              And isnull(out_no,'')<>'' and isnull(out_sq,'')<>''   -- 출고완료
            
            Update A Set progclss_bc='SE19020' --출고완료                
            From sep215 A
            Where file_no=@file_no and file_sq=@file_sq
              And (qty-isnull(blqty,0))>0 --b/l처리가 완료되지 않은 경우
              And isnull(out_no,'')<>'' and isnull(out_sq,'')<>''
            
            Update A Set progclss_bc='SE19010' --등록                
            From sep215 A
            Where file_no=@file_no and file_sq=@file_sq
              And isnull(out_no,'')='' and isnull(out_sq,'')='' -- 미출고처리

--select * from sep215
--where  file_no=@file_no and file_sq=@file_sq
            
            IF Exists(Select 1 From Sep215 A  where file_no=@file_no and file_sq=@file_sq  and progclss_bc='SE19010')
            Begin
               Update A Set progress_bc='SE19010'
                From sep210 A
                Where file_no=@file_no  
                REturn
            end
            
            IF Exists(Select 1 From Sep215 A  where file_no=@file_no and file_sq=@file_sq  and progclss_bc='SE19020')
            Begin
               Update A Set progress_bc='SE19020'
                From sep210 A
                Where file_no=@file_no  
                REturn
            end
            
             IF Exists(Select 1 From Sep215 A  where file_no=@file_no and file_sq=@file_sq  and progclss_bc='SE19030')
            Begin
               Update A Set progress_bc='SE19030'
                From sep210 A
                Where file_no=@file_no  
                REturn
            end           


            
		END	
		FETCH NEXT FROM Acur INTO 
			@file_no, @file_sq, @qty, @dprogclss_bc, @blqty, @closeqty,@ty
	END	-- FETCH WHILE 문의 END

	CLOSE Acur
	DEALLOCATE Acur

RETURN

error:
	CLOSE Acur
	DEALLOCATE Acur
    select @msg = '에러가 발생하였습니다.'
	RAISERROR 30001 @msg
	ROLLBACK	TRANSACTION



go


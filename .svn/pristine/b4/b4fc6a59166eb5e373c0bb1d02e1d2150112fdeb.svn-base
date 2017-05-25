 
--***************************************************************************************************
-- Description :	 입출고테이블에 이뤄지는 작업을 집계함	
--***************************************************************************************************

create	TRIGGER [dbo].[SEP215_Delete] ON [dbo].[SEP215]
FOR  DELETE 
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
						ty = 'd'
				FROM	DELETED
				----UNION all
				--SELECT	file_no, file_sq, 
				--		qty, progclss_bc, isnull(blqty,0)blqty, closeqty,
				--		ty = 'i'
				--FROM	INSERTED
			) a	
			
        where 1=1 
		order by a.ty


	OPEN Acur
		FETCH NEXT FROM Acur INTO 
			@file_no, @file_sq, @qty, @dprogclss_bc, @blqty, @closeqty,@ty
			
--select @file_no, @file_sq, @qty, @dprogclss_bc, @blqty, @closeqty,@ty
	WHILE @@FETCH_STATUS = 0
	BEGIN

		IF @ty = 'd' 
		BEGIN
		    If Not Exists(Select 1 from  Sep215 A  where file_no=@file_no )
		    Begin
		        Update A Set progress_bc='SE19010'
                From sep210 A
                Where file_no=@file_no  
                REturn
		    End
		    
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

--exec sp_executesql N'update	a
--set	a.file_no = @file_no, a.file_sq = @file_sq, a.itm_id = @itm_id, a.um_bc = @um_bc, 
--	a.qty = @qty, a.up = @up,a.korup=@korup, a.famt = @famt, a.amt = @amt, a.fac_cd = @fac_cd, 
--	a.wh_cd = @wh_cd, a.rmks = @rmks, a.progclss_bc = @progclss_bc, a.blqty = @blqty, 
--	a.closeqty = @closeqty, a.ctno = @ctno, a.lotno = @lotno, a.out_no = @out_no,a.out_sq=@out_sq,
--	  a.mid = 7, a.mdt = getdate()
--from	sep215 a
--where	a.file_no = @file_no_old
--and	a.file_sq = @file_sq_old


--if @chk = ''1'' and (@work_ty = ''save'' or @work_ty = ''delete'')
--begin
--	if isnull(@fac_cd,'''') = '''' or isnull(@wh_cd,'''') = ''''
--	begin
--		raiserror 50000 ''출고공장, 출고창고는 필수입니다''
--		return
--	end
--	if @work_ty=''save''
--		exec sep215_moveout @file_no,@file_sq,7
--	else
--		exec sep215_moveoutcancel @file_no,@file_sq,7


----	exec SEF100_Work	@file_no, @file_sq, @work_ty, 7
--end
--',N'@amt decimal(12,5),@blqty decimal(29,0),@chk nvarchar(1),@closeqty decimal(29,0),@ctno nvarchar(4000),@fac_cd nvarchar(2),@famt decimal(9,5),@file_no nvarchar(13),@file_no_old nvarchar(13),@file_sq int,@file_sq_old int,@itm_id int,@korup decimal(10,5),@lotno nvarchar(4000),@out_no nvarchar(4000),@out_sq int,@progclss_bc nvarchar(7),@qty decimal(8,5),@rmks nvarchar(4000),@um_bc nvarchar(8),@up decimal(7,5),@wh_cd nvarchar(4),@work_ty nvarchar(4)',@amt=8600150.00000,@blqty=NULL,@chk=N'1',@closeqty=NULL,@ctno=NULL,@fac_cd=N'01',@famt=6565.00000,@file_no=N'2011042000002',@file_no_old=N'2011042000002',@file_sq=1,@file_sq_old=1,@itm_id=4125,@korup=34400.60000,@lotno=NULL,@out_no=N'',@out_sq=0,@progclss_bc=N'SE19010',@qty=250.00000,@rmks=NULL,@um_bc=N'DM150100',@up=26.26000,@wh_cd=N'WH07',@work_ty=N'save'
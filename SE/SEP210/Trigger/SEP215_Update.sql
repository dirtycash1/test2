 
--***************************************************************************************************
-- Description :	 ��������̺� �̷����� �۾��� ������	
--***************************************************************************************************

alter	TRIGGER [dbo].[SEP215_Update] ON [dbo].[SEP215]
FOR INSERT, UPDATE--, DELETE 
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

--��뺯�� ����
DECLARE	@file_no			VARCHAR(20),	--�̵���ȣ
		@file_sq			INT,			--�̵�����
		@qty			DECIMAL(18, 5),	--��
		@mprogclss_bc		VARCHAR(10),		--������
		@dprogclss_bc		VARCHAR(10),		--������
		@blqty			DECIMAL(18, 5),	--��
		@closeqty			DECIMAL(18, 5),	--��		
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
            Update A set progclss_bc='SE19030' --b/l����Ϸ� 
            From sep215 A
            Where file_no=@file_no and file_sq=@file_sq
              And (qty-isnull(blqty,0))<=0    --b/ló���Ϸ�
              And isnull(out_no,'')<>'' and isnull(out_sq,'')<>''   -- ���Ϸ�
            
            Update A Set progclss_bc='SE19020' --���Ϸ�                
            From sep215 A
            Where file_no=@file_no and file_sq=@file_sq
              And (qty-isnull(blqty,0))>0 --b/ló���� �Ϸ���� ���� ���
              And isnull(out_no,'')<>'' and isnull(out_sq,'')<>''
            
            Update A Set progclss_bc='SE19010' --���                
            From sep215 A
            Where file_no=@file_no and file_sq=@file_sq
              And isnull(out_no,'')='' and isnull(out_sq,'')='' -- �����ó��

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
	END	-- FETCH WHILE ���� END

	CLOSE Acur
	DEALLOCATE Acur

RETURN

error:
	CLOSE Acur
	DEALLOCATE Acur
    select @msg = '������ �߻��Ͽ����ϴ�.'
	RAISERROR 30001 @msg
	ROLLBACK	TRANSACTION



go


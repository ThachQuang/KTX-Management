use KTX
go
create proc SP_Delete_Phong (@id_phong int)
as
BEGIN TRY
BEGIN TRANSACTION
	DELETE FROM NOITHAT where id_phong = @id_phong
	DELETE FROM DIEN where id_phong = @id_phong
	DELETE FROM NUOC where id_phong = @id_phong
	DELETE FROM DICHVUCHUNG where id_phong = @id_phong
	DELETE FROM PHONG where id_phong = @id_phong
COMMIT
END TRY
BEGIN CATCH
	if(@@TRANCOUNT > 0)
		ROLLBACK TRAN
END CATCH
GO
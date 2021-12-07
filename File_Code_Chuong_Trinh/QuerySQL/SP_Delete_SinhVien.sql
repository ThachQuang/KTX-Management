use KTX
go
CREATE PROC SP_Delete_SinhVien (@id_sinhvien int)
AS
BEGIN TRY
BEGIN TRANSACTION
	DELETE FROM PHUHUYNH where id_sinhvien = @id_sinhvien
	DELETE FROM VIPHAM where id_sinhvien = @id_sinhvien
	DELETE FROM DICHVURIENG where id_sinhvien = @id_sinhvien
	DELETE FROM SINHVIEN where id_sinhvien = @id_sinhvien
COMMIT
END TRY
BEGIN CATCH
	if(@@TRANCOUNT > 0)
		ROLLBACK TRAN
END CATCH
GO
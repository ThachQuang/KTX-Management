use KTX
go
create proc SP_Delete_PhuHuynh (@id_sinhvien int)
as
delete from PHUHUYNH where id_sinhvien = @id_sinhvien;
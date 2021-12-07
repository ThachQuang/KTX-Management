use KTX
go
create proc SP_Delete_DichVuRieng (@id_sinhvien int)
as
delete from DICHVURIENG where id_sinhvien = @id_sinhvien;
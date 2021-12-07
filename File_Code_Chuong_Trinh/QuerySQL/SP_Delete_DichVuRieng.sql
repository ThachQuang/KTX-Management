use KTX
go
create proc SP_Delete_DichVuRieng (@id_sinhvien int, @thang tinyint)
as
delete from DICHVURIENG where DICHVURIENG.id_sinhvien = @id_sinhvien and DICHVURIENG.thang = @thang;
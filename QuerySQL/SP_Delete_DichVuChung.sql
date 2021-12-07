use KTX
go
create proc SP_Delete_DichVuChung (@id_phong int, @thang tinyint)
as
delete from DICHVUCHUNG where DICHVUCHUNG.id_phong = @id_phong and DICHVUCHUNG.thang = @thang;
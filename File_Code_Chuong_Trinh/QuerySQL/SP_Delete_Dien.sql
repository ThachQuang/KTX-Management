use KTX
go
create proc SP_Delete_Dien (@id_phong int, @thang tinyint)
as
delete from DIEN
where DIEN.id_phong = @id_phong and DIEN.thang = @thang
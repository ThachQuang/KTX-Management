use KTX
go
create proc SP_Delete_NoiThat (@id_phong int)
as
delete from NOITHAT where id_phong = @id_phong;
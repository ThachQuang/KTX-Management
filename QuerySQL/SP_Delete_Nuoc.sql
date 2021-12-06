use KTX
go
create proc SP_Delete_Nuoc (@id_phong int, @thang tinyint)
as
delete from NUOC
where NUOC.id_phong = @id_phong and NUOC.thang = @thang
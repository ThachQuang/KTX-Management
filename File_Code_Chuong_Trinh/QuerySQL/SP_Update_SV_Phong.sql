use KTX
go
create proc SP_Update_SV_Phong (@id_phong int, @so_nguoi_o tinyint)
as
update PHONG
set
so_nguoi = @so_nguoi_o
where id_phong = @id_phong
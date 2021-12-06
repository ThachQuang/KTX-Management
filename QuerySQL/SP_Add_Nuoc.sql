use KTX
go
create proc SP_Add_Nuoc (@id_phong int, @thang tinyint, @so_dau int, @so_cuoi int, @thanh_tien int)
as
insert into NUOC(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (@id_phong, @thang, @so_dau, @so_cuoi, @thanh_tien)
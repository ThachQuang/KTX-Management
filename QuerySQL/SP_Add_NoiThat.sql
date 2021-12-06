use KTX
go
create proc SP_Add_NoiThat (@id_phong int, @ten_noi_that nvarchar(50), @so_luong tinyint, @tinh_trang bit)
as
insert into NOITHAT(id_phong, ten_noi_that,so_luong, tinh_trang)
values (@id_phong, @ten_noi_that, @so_luong, @tinh_trang)
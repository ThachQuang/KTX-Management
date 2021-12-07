use KTX
go
create proc SP_Add_Phong (@ten varchar(10), @khu varchar(10), @tang tinyint, @suc_chua tinyint, @so_nguoi tinyint, @dien_tich float, @gia_thue int, @phi_thu_thang int)
as
insert into PHONG(ten_phong, khu, tang, suc_chua, so_nguoi, dien_tich, gia_thue, phi_thu_thang)
values (@ten, @khu, @tang, @suc_chua, @so_nguoi, @dien_tich, @gia_thue, '0')
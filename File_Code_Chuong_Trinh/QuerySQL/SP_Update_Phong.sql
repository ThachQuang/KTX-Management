use KTX
go
create proc SP_Update_Phong (@id_phong int,@ten varchar(10), @khu varchar(10), @tang tinyint, @suc_chua tinyint, @so_nguoi tinyint, @dien_tich float, @gia_thue int, @phi_thu_thang int)
as
update PHONG
set
	ten_phong = @ten,
	khu =@khu,
	tang = @tang,
	suc_chua = @suc_chua,
	so_nguoi = @so_nguoi,
	dien_tich = @dien_tich,
	gia_thue = @gia_thue,
	phi_thu_thang = @phi_thu_thang
where
id_phong = @id_phong;
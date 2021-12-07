use KTX
go
create proc SP_Add_SinhVien
(
	@id_phong int,
	@ten nvarchar(50),
	@ngay_sinh date,
	@gioi_tinh bit,
	@que_quan nvarchar(30),
	@nghe_nghiep nvarchar(30),
	@sdt varchar(15),
	@cmnd varchar(20),
	@bhyt varchar(20),
	@noi_lam_viec nvarchar(256),
	@ho_khau nvarchar(256),
	@sv_nam tinyint,
	@hop_dong_start date,
	@hop_dong_end date
)
as
insert into SINHVIEN 
(
	id_phong,
	ten,
	ngay_sinh,
	gioi_tinh,
	que_quan,
	nghe_nghiep,
	sdt,
	cmnd,
	bhyt,
	noi_lam_viec,
	ho_khau,
	sv_nam,
	hop_dong_start,
	hop_dong_end
)
values
(
	@id_phong,
	@ten,
	@ngay_sinh,
	@gioi_tinh,
	@que_quan,
	@nghe_nghiep,
	@sdt,
	@cmnd,
	@bhyt,
	@noi_lam_viec,
	@ho_khau,
	@sv_nam,
	@hop_dong_start,
	@hop_dong_end
)

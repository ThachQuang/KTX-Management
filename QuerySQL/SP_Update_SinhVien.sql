use KTX
go
create proc SP_Update_SinhVien
(
	@id_sinhvien int,
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
	@sv_nam tinyint
)
as
update SINHVIEN
set
	id_phong = @id_phong,
	ten = @ten,
	ngay_sinh =@ngay_sinh,
	gioi_tinh = @gioi_tinh,
	que_quan = @que_quan,
	nghe_nghiep = @nghe_nghiep,
	sdt = @sdt,
	cmnd = @cmnd,
	bhyt = @bhyt,
	noi_lam_viec = @noi_lam_viec,
	ho_khau = @ho_khau,
	sv_nam = @sv_nam
where
id_sinhvien = @id_sinhvien;
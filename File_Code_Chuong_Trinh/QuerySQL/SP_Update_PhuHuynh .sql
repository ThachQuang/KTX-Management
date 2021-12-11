use KTX
go
create proc SP_Update_PhuHuynh
(
	@id_sinhvien int,
	@id_phuhuynh int,
	@ten nvarchar(50),
	@ngay_sinh date,
	@gioi_tinh bit,
	@que_quan nvarchar(30),
	@nghe_nghiep nvarchar(30),
	@sdt varchar(15)
)
as
update PHUHUYNH
set
	id_sinhvien = @id_sinhvien,
	ten = @ten,
	ngay_sinh =@ngay_sinh,
	gioi_tinh = @gioi_tinh,
	que_quan = @que_quan,
	nghe_nghiep = @nghe_nghiep,
	sdt = @sdt
where
PHUHUYNH.id_phuhuynh = @id_phuhuynh
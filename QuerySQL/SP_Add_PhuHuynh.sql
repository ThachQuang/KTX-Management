use KTX
go
create proc SP_Add_PhuHuynh
(
	@id_sinhvien int,
	@ten nvarchar(50),
	@ngay_sinh date,
	@gioi_tinh bit,
	@que_quan nvarchar(30),
	@nghe_nghiep nvarchar(30),
	@sdt varchar(15)
)
as
insert into PHUHUYNH
(
	id_sinhvien,
	ten,
	ngay_sinh,
	gioi_tinh,
	que_quan,
	nghe_nghiep,
	sdt
)
values
(
	@id_sinhvien,
	@ten,
	@ngay_sinh,
	@gioi_tinh,
	@que_quan,
	@nghe_nghiep,
	@sdt
)
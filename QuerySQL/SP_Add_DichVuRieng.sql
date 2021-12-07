use KTX
go
create proc SP_Add_DichVuRieng
(
	@id_sinhvien int,
	@thang tinyint,
	@dich_vu_1 tinyint,
	@dich_vu_2 tinyint,
	@dich_vu_3 tinyint,
	@thanh_tien int
)
as
insert into DICHVURIENG
(
	id_sinhvien,
	thang,
	dich_vu_1,
	dich_vu_2,
	dich_vu_3,
	thanh_tien
)
values
(
	@id_sinhvien,
	@thang,
	@dich_vu_1,
	@dich_vu_2,
	@dich_vu_3,
	@thanh_tien
)
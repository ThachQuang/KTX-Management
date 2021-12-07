use KTX
go
create proc SP_Add_DichVuChung
(
	@id_phong int,
	@thang tinyint,
	@dich_vu_1 tinyint,
	@dich_vu_2 tinyint,
	@thanh_tien int
)
as
insert into DICHVUCHUNG
(
	id_phong,
	thang,
	dich_vu_1,
	dich_vu_2,
	thanh_tien
)
values
(
	@id_phong,
	@thang,
	@dich_vu_1,
	@dich_vu_2,
	@thanh_tien
)
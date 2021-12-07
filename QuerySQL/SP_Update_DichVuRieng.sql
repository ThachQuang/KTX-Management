use KTX
go
create proc SP_Update_DichVuRieng
(
	@id_sinhvien int,
	@thang tinyint,
	@dich_vu_1 tinyint,
	@dich_vu_2 tinyint,
	@dich_vu_3 tinyint,
	@thanh_tien int
)
as
update DICHVURIENG
set
	id_sinhvien = @id_sinhvien,
	thang=@thang,
	dich_vu_1=@dich_vu_1,
	dich_vu_2=@dich_vu_2,
	dich_vu_3=@dich_vu_3,
	thanh_tien=@thanh_tien
where
id_sinhvien = @id_sinhvien;
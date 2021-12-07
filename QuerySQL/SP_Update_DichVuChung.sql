use KTX
go
create proc SP_Update_DichVuChung
(
	@id_phong int,
	@thang tinyint,
	@dich_vu_1 tinyint,
	@dich_vu_2 tinyint,
	@thanh_tien int
)
as
update DICHVUCHUNG
set
	id_phong = @id_phong,
	thang=@thang,
	dich_vu_1=@dich_vu_1,
	dich_vu_2=@dich_vu_2,
	thanh_tien=@thanh_tien
where
DICHVUCHUNG.id_phong = @id_phong and DICHVUCHUNG.thang = @thang;
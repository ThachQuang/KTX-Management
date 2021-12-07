use KTX
go
create proc SP_Update_HopDong
(
	@id_sinhvien int,
	@hop_dong_start date,
	@hop_dong_end date
)
as
update SINHVIEN
set
	hop_dong_start = @hop_dong_start,
	hop_dong_end = @hop_dong_end
where
id_sinhvien = @id_sinhvien;
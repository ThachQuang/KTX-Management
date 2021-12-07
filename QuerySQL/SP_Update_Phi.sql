use KTX
go
create proc SP_Update_Phi (@id_phong int, @phi_thu_thang int)
as
update PHONG
set phi_thu_thang = @phi_thu_thang
where id_phong = @id_phong;
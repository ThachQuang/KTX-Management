use KTX
go
create proc SP_Delete_PhuHuynh (@id_phuhuynh int)
as
delete from PHUHUYNH where id_phuhuynh = @id_phuhuynh;
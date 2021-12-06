use KTX
go

insert into PHONG(ten_phong, khu, tang, suc_chua, so_nguoi, dien_tich, gia_thue, phi_thu_thang)
values ('A101', 'A', 1, 2, 2, 50, 5000000, 0) 
insert into PHONG(ten_phong, khu, tang, suc_chua, so_nguoi, dien_tich, gia_thue, phi_thu_thang)
values ('B101', 'B', 1, 2, 2, 50, 5000000, 0) 
insert into PHONG(ten_phong, khu, tang, suc_chua, so_nguoi, dien_tich, gia_thue, phi_thu_thang)
values ('C201', 'C', 2, 2, 1, 50, 5000000, 0)
go

insert into NOITHAT(id_phong, ten_noi_that, so_luong, tinh_trang)
values (1, N'Giường đôi 2 tầng', 1, 0)
insert into NOITHAT(id_phong, ten_noi_that, so_luong, tinh_trang)
values (2, N'Giường đôi 2 tầng', 1, 0) 
insert into NOITHAT(id_phong, ten_noi_that, so_luong, tinh_trang)
values (3, N'Tủ sắt', 1, 1)
go

insert into DIEN(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (1, 7, 2021, 2102, 0)
insert into DIEN(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (2, 7, 1738, 1785, 0)
insert into DIEN(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (3, 6, 3201, 3234, 0)
go

insert into NUOC(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (1, 7, 2021, 2102, 0)
insert into NUOC(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (2, 7, 1738, 1785, 0)
insert into NUOC(id_phong, thang, so_dau, so_cuoi, thanh_tien)
values (3, 6, 3201, 3234, 0)
go

insert into GIADICHVU(ten_dichvu, gia_dichvu)
values (N'Wifi chung', 320000)
insert into GIADICHVU(id_dichvu, ten_dichvu, gia_dichvu)
values (N'Sửa chữa', 30000)
insert into GIADICHVU(id_dichvu, ten_dichvu, gia_dichvu)
values (N'Giặt xả', 20000)
insert into GIADICHVU(id_dichvu, ten_dichvu, gia_dichvu)
values (N'Gửi xe', 70000)
insert into GIADICHVU(id_dichvu, ten_dichvu, gia_dichvu)
values (N'Wifi cá nhân', 50000)
go

insert into DICHVUCHUNG(id_phong, thang, dich_vu_1, dich_vu_2, thanh_tien)
values (1, 7, 1, 0, 0)
insert into DICHVUCHUNG(id_phong, thang, dich_vu_1, dich_vu_2, thanh_tien)
values (2, 7, 0, 0, 0)
insert into DICHVUCHUNG(id_phong, thang, dich_vu_1, dich_vu_2, thanh_tien)
values (3, 6, 0, 1, 0)
go

insert into SINHVIEN(id_phong, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt, cmnd, noi_lam_viec, ho_khau, sv_nam)
values (1, N'Nguyễn Văn A', '2002/01/01', 1, N'Đồng Nai', N'Sinh viên', '123', '123', 'ĐH XYZ', N'Đồng Nai', 2)
insert into SINHVIEN(id_phong, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt, cmnd, noi_lam_viec, ho_khau, sv_nam)
values (1, N'Phạm Văn B', '2002/06/06', 1, N'Cà Mau', N'Sinh viên', '456', '456', 'ĐH XYZ', N'Cà Mau', 2)
insert into SINHVIEN(id_phong, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt, cmnd, noi_lam_viec, ho_khau, sv_nam)
values (2, N'Đỗ Thị C', '2003/12/12', 0, N'Hà Nội', N'Sinh viên', '789', '1789', 'ĐH XYZ', N'Hà Nội', 1)
insert into SINHVIEN(id_phong, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt, cmnd, noi_lam_viec, ho_khau, sv_nam)
values (2, N'Lương Văn D', '2003/2/27', 0, N'Đồng Nai', N'Sinh viên', '142', '142', 'ĐH XYZ', N'Đồng Nai', 1)
insert into SINHVIEN(id_phong, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt, cmnd, noi_lam_viec, ho_khau, sv_nam)
values (3, N'Phan Văn E', '2001/05/23', 1, N'Tây Nguyên', N'Sinh viên', '102', '102', 'ĐH XYZ', N'Tây Nguyên', 3)
go

insert into PHUHUYNH(id_sinhvien, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt)
values (1, N'Nguyễn Văn A', '2002/01/01', 1, N'Đồng Nai', N'Tự do', '123')
insert into PHUHUYNH(id_sinhvien, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt)
values (1, N'Phạm Văn B', '2002/06/06', 0, N'Cà Mau', N'Giáo viên', '456')
insert into PHUHUYNH(id_sinhvien, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt)
values (2, N'Đỗ Thị C', '2003/12/12', 0, N'Hà Nội', N'Buôn bán', '789')
insert into PHUHUYNH(id_sinhvien, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt)
values (2, N'Lương Văn D', '2003/2/27', 1, N'Đồng Nai', N'Quản lí', '235')
insert into PHUHUYNH(id_sinhvien, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt)
values (3, N'Phan Văn E', '2001/05/23', 1, N'Tây Nguyên', N'Bộ đội', '526')
go

drop table HocSinh;

create table HocSinh (
	Ten varchar(100),
	Cmnd varchar(100),
	Diachi varchar(255),
	Namsinh DateTime,
	Email varchar(100),
	Phoneno varchar(100),
	Gioitinh varchar(10),
	Diemtb decimal(10, 1)
);

insert into HocSinh (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh, Diemtb)
values ('nva1','123','hcm', '2003-01-01', 'nva@gmail.com', '012-3456-789', 'nam', '5.5');

insert into HocSinh (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh, Diemtb)
values ('nva2','124','hcm', '2003-01-01', 'nva@gmail.com', '012-3456-789', 'nam', '6.9');

insert into HocSinh (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh, Diemtb)
values ('nva3','125','hcm', '2003-01-01', 'nva@gmail.com', '012-3456-789', 'nam', '8.1');

insert into HocSinh (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh, Diemtb)
values ('nva4','126','hcm', '2003-01-01', 'nva@gmail.com', '012-3456-789', 'nam', '4.5');

insert into HocSinh (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh, Diemtb)
values ('nva5','127','hcm', '2003-01-01', 'nva@gmail.com', '012-3456-789', 'nam', '6.3');

drop table GiaoVien;

create table GiaoVien (
	Ten varchar(100),
	Cmnd varchar(100),
	Diachi varchar(255),
	Namsinh DateTime,
	Email varchar(100),
	Phoneno varchar(100),
	Gioitinh varchar(10)
);

insert into GiaoVien (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh)
values ('ntb1','023','hcm', '1990-01-01', 'ntb@gmail.com', '012-3456-789', 'nu');

insert into GiaoVien (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh)
values ('ntb2','024','hcm', '1990-01-01', 'ntb@gmail.com', '012-3456-789', 'nu');

insert into GiaoVien (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh)
values ('ntb3','025','hcm', '1990-01-01', 'ntb@gmail.com', '012-3456-789', 'nu');

insert into GiaoVien (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh)
values ('ntb4','026','hcm', '1990-01-01', 'ntb@gmail.com', '012-3456-789', 'nu');

insert into GiaoVien (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh)
values ('ntb5','027','hcm', '1990-01-01', 'ntb@gmail.com', '012-3456-789', 'nu');

select * from HocSinh;

select * from GiaoVien;
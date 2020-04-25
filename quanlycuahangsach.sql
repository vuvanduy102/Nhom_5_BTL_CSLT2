
use ql
create table linhvuc
(
	malinhvuc nvarchar(5) primary key,
	tenlinhvuc nvarchar(30)
)
create table nhaxuatban
(
	manhaxuatban nvarchar(5) primary key,
	tennxb nvarchar(30),
	diachi nvarchar(40),
	sodt nvarchar(12)
)
create table tacgia
(
	matacgia nvarchar(5) primary key,
	tentacgia nvarchar(30),
	ngaysinh date,
	gioitinh nvarchar(10),
	diachi nvarchar(40)
)
create table ngonngu
(
	mangonngu nvarchar(5) primary key,
	tenngonngu nvarchar(30)
)
create table loaisach
(
	maloaisach nvarchar(5) primary key,
	tenloaisach nvarchar(40)
)
create table tinhtrang
(
	matinhtrang nvarchar(5) primary key,
	tentinhtrang nvarchar(40),
)
create table vipham
(
	mavipham nvarchar(5) primary key,
	tenvipham nvarchar(30),
	tienphat int
)
create table calam
(
	maca nvarchar(5) primary key,
	tenca nvarchar(20)
)
create table sachtruyen
(
	masach nvarchar(5) primary key,
	tensach nvarchar(50),
	maloaisach nvarchar(5),
	foreign key (maloaisach) references loaisach(maloaisach),
	malinhvuc nvarchar(5),
	foreign key (malinhvuc) references linhvuc(malinhvuc),
	matacgia nvarchar(5),
	foreign key (matacgia) references tacgia(matacgia),
	manhaxuatban nvarchar(5),
	foreign key (manhaxuatban) references nhaxuatban(manhaxuatban),
	mangonngu nvarchar(5),
	foreign key (mangonngu) references ngonngu(mangonngu),
	sotrang int,
	giasach int,
	dongiathue int,
	soluong int,
	anh image,
	ghichu nvarchar(50)
)
create table khachhang
(
	makhach nvarchar(5) primary key,
	tenkhach nvarchar(30),
	ngaysinh date,
	gioitinh nvarchar(10),
	diachi nvarchar(30)
)
create table nhanvien
(
	manhanvien nvarchar(5) primary key,
	Tennhanvien nvarchar(30),
	maca nvarchar(5),
	foreign key (maca) references calam(maca),
	namsinh date,
	gioitinh nvarchar(10),
	diachi nvarchar(30),
	sodienthoai nvarchar(12),
	luongthang int,
)
create table thuesach
(
	mathue nvarchar(5) primary key,
	makhach nvarchar(5),
	foreign key (makhach) references khachhang(makhach),
	manhanvien nvarchar(5),
	foreign key (manhanvien) references nhanvien(manhanvien),
	ngaythue date,
	tiendatcoc int,
)
create table chitietthuesach
(
	mathue nvarchar(5),
	masach nvarchar(5),
	foreign key (mathue) references thuesach(mathue),
	foreign key (masach) references sachtruyen(masach),
	primary key(mathue,masach),
	matinhtrang nvarchar(5),
	foreign key (matinhtrang) references tinhtrang(matinhtrang),
	datra nvarchar(10),
)
create table trasach
(
	matra nvarchar(5) primary key,
	mathue nvarchar(5),
	foreign key (mathue) references thuesach(mathue),
	manhanvien nvarchar(5),
	foreign key (manhanvien) references nhanvien(manhanvien),
	ngaytra date,
	tongtien int
)
create table chitiettrasach
(
	matra nvarchar(5),
	masach nvarchar(5),
	foreign key (matra) references trasach(matra),
	foreign key (masach) references sachtruyen(masach),
	primary key(matra,masach),
	mavipham nvarchar(5),
	foreign key (mavipham) references vipham(mavipham),
	thanhtien int,
)
alter table chitiettrasach drop column thanhtien

alter table tacgia
add constraint cc_gioitinh check (gioitinh = 'nam' or gioitinh = 'nu')
alter table nhanvien
add constraint cc_gioitinh1 check (gioitinh = 'nam' or gioitinh = 'nu')
alter table khachhang
add constraint cc_gioitinh2 check (gioitinh = 'nam' or gioitinh = 'nu')
alter table khachhang
add constraint df_namsinh default getdate() for ngaysinh
alter table nhanvien
add constraint df_ngaysinh default getdate() for namsinh
alter table tacgia
add constraint df_ngaysinh1 default getdate() for ngaysinh

insert into linhvuc values ('ls01','sach lich su')
insert into linhvuc values ('sci02','sach toan hoc')
insert into linhvuc values ('sci03','sach vat ly')
insert into nhaxuatban values ('nxb01','hong ha','ha noi','0123456789')
insert into nhaxuatban values('nxb02','tuoi tre','ha noi','0123116789')
insert into nhaxuatban values('nxb03','kim dong','ha noi','01233356789')
insert into tacgia values('tg01','nguyen ha','19800910','nam','ha noi')
insert into tacgia values('tg02','nguyen an','19800919','nu','ha noi')
insert into tacgia values('tg03','nguyen anh','19800928','nam','ha noi')
insert into ngonngu values ('eng','tieng anh')
insert into ngonngu values('chn','tieng trung')
insert into ngonngu values('fre','tieng phap')
insert into loaisach values('new02','moi')
insert into loaisach values('new01','moi')
insert into loaisach values('old01','cu')
insert into tinhtrang values('c01','dang co san')
insert into tinhtrang values('ch01','dang co san')
insert into tinhtrang values('tr01','da het')
insert into vipham values ('vp01','lam mat',50000)
insert into vipham values('vp02','lam hong',50000)
insert into calam values('mor','ca sang')
insert into calam values('aft','ca chieu')
insert into calam values('nig','ca toi')
insert into sachtruyen values ('bko1','van','new01','sci02','tg02','nxb03','eng',400,200000,30000,100,'','')
insert into sachtruyen values ('bko2','mo hinh toan','new01','sci02','tg02','nxb03','eng',400,200000,30000,100,'','')
insert into sachtruyen values ('bko3','toan cao cap','new01','sci02','tg03','nxb02','eng',400,200000,30000,100,'','')
insert into sachtruyen values ('bko4','ly','new01','sci02','tg03','nxb02','eng',400,200000,30000,100,'','')
insert into sachtruyen values ('bko5','hoa','new01','sci02','tg03','nxb02','eng',400,200000,30000,100,'','')
insert into sachtruyen values ('bko6','su','new01','sci02','tg03','nxb02','eng',400,200000,30000,100,'','')
insert into khachhang values('k01','le a','19991009','nam','ha noi')
insert into khachhang values('k02','van a','19991209','nam','ha noi')
insert into khachhang values('k03','minh a','19991109','nu','ha noi')
insert into khachhang values('k05','nguyen hien','19900807','nu','binh duong')
insert into khachhang values('k04','bao an','19980908','nu','sai gon')
insert into nhanvien values('nv01','duong anh','mor','19890910','nam','binh duong','012335444',6000000)
insert into nhanvien values('nv02','manh an','aft','19891210','nam','binh duong','0126635444',6000000)
insert into nhanvien values('nv03','duong manh','nig','19900910','nam','binh duong','012335444',6000000)
insert into nhanvien values('nv04','duc manh','mor','19900807','nam','thai binh','06776665',7000000)
insert into thuesach values('thue1','k01','nv01','20200202',70000)
insert into thuesach values('thue2','k02','nv02','20200302',40000)
insert into thuesach values('thue3','k03','nv03','20200202',50000)
insert into thuesach values('thue4','k04','nv03','20200908',40000)
insert into thuesach values('thue5','k05','nv04','20200908',200000)
insert into chitietthuesach values('thue1','bko1','c01','')
insert into chitietthuesach values('thue2','bko2','c01','40000')
insert into chitietthuesach values('thue3','bko3','c01','')
insert into chitietthuesach values('thue4','bko1','c01','40000')
insert into chitietthuesach values('thue3','bko3','c01','40000')
insert into chitietthuesach values('thue2','bko4','c01','40000')
insert into chitietthuesach values('thue3','bko5','c01','40000')
insert into chitietthuesach values('thue4','bko1','c01','40000')
insert into chitietthuesach values('thue4','bko6','c01','40000')
insert into trasach values('tra01','thue1','nv01','20201104',null)
insert into trasach values('tra02','thue2','nv02','20200405',120000)
insert into trasach values('tra03','thue3','nv03','20200704',130000)
insert into trasach values('tra04','thue4','nv03','20201204',130000)
insert into chitiettrasach values ('tra04','bko6','vp01')
insert into chitiettrasach values('tra02','bko2','vp01')
insert into chitiettrasach values('tra03','bko3','vp02')
insert into chitiettrasach values('tra01','bko1','vp02')
insert into chitiettrasach values('tra02','bko4','vp02')
insert into chitiettrasach values('tra03','bko5','vp02')
delete from chitiettrasach where matra='tra04'
delete from trasach where matra='tra04'

create trigger capnhat on chitietthuesach after insert
as
begin
	update sachtruyen
	set soluong =soluong-(
		select count(masach)
		from inserted
		where masach=sachtruyen.masach
	)
	from sachtruyen join inserted on sachtruyen.masach=inserted.masach
end;

create trigger capnhattra on chitiettrasach after insert
as
begin
	update sachtruyen
	set soluong =soluong+(
		select count(masach)
		from inserted
		where masach=sachtruyen.masach
	)
	from sachtruyen join inserted on sachtruyen.masach=inserted.masach
end;








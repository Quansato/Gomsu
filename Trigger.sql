USE QUANLYGOMSUN
GO
--Câu1 Cập nhật số lượng khi nhập hàng4
CREATE  TRIGGER capnhatnhap ON dbo.ChitietHDN
FOR INSERT,UPDATE
AS
BEGIN
DECLARE @mahang NVARCHAR(20), @soluong INT
SELECT @mahang = Inserted.Mahang,@soluong = Inserted.Soluong
FROM Inserted 
UPDATE dbo.DMhanghoa SET Soluong =  @soluong+ISNULL(Soluong,0) WHERE  Mahang = @mahang  
END
GO
--cau 1 Nếu số lượng lớn hơn Số lượng hiện tại báo lỗi


CREATE TRIGGER CAPNHATLOI ON dbo.ChitietHDB
FOR INSERT,UPDATE
AS
BEGIN
 DECLARE @mahang NVARCHAR(20),@soluong INT,@soluonght INT ,@check INT
 SELECT @mahang = Inserted.Mahang,@soluong = Inserted.Soluong,@soluonght = dbo.DMhanghoa.Soluong
 FROM Inserted LEFT JOIN  dbo.DMhanghoa ON DMhanghoa.Mahang = Inserted.Mahang
 IF (@soluong <= @soluonght)
 BEGIN
 RAISERROR(N'Sản Phẩm Đã Hết Hàng Hoặc Không Đủ Hàng !',16,1)
 ROLLBACK TRANSACTION
 END
 -- Câu 1 Cập nhật số lương hàng hóa khi bán hóa.
 CREATE TRIGGER capnhatbanHANG ON dbo.ChitietHDB
FOR INSERT,UPDATE
AS
BEGIN
 DECLARE @mahang NVARCHAR(20),@soluong INT,@soluonght INT ,@check INT
 SELECT @mahang = Inserted.Mahang,@soluong = Inserted.Soluong,@soluonght = dbo.DMhanghoa.Soluong
 FROM Inserted LEFT JOIN  dbo.DMhanghoa ON DMhanghoa.Mahang = Inserted.Mahang
 UPDATE dbo.DMhanghoa SET Soluong = Soluong - @soluong WHERE @mahang = Mahang
 END
 
 
--cau 2 cap nhat gia trong DMhangHoa tuwf bang HDN
CREATE TRIGGER capnhatgianhap ON dbo.ChitietHDN
FOR INSERT,UPDATE
AS
BEGIN
DECLARE @mahang NVARCHAR(20),@gianhap INT
SELECT @mahang = Inserted.Mahang,@gianhap = Inserted.Dongia
FROM Inserted
UPDATE dbo.DMhanghoa SET Dongianhap = @gianhap WHERE @mahang = Mahang
END
GO
--cau 3 Cap nhat gia ban tu bang chi tiet HDN
CREATE TRIGGER capnhatgiabanhang ON dbo.ChitietHDN
FOR UPDATE,INSERT
AS
BEGIN
DECLARE @mahang NVARCHAR(20),@dongiaban INT
SELECT @mahang = Inserted.Mahang,@dongiaban = Inserted.Dongia
FROM Inserted
UPDATE dbo.DMhanghoa SET Dongiaban = (110*@dongiaban)/100 WHERE Mahang =@mahang
 
END
GO


-- Tao function tìm kiếm hóa đơn



CREATE FUNCTION TimTheoMH(@mahang NVARCHAR(20))
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE dbo.ChitietHDB.Mahang = @mahang
)
GO

CREATE FUNCTION TimTheoNB(@ngayban date )
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE  dbo.Hoadonban.Ngayban = @ngayban
)
GO

CREATE FUNCTION TimTheoTT(@TongTien float )
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE  dbo.Hoadonban.Tongtien = @TongTien
)
GO

CREATE FUNCTION TimTheo3loai(@mahang NVARCHAR(20),@ngayban DATE,@tongtien FLOAT )
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE  dbo.Hoadonban.Ngayban = @ngayban AND dbo.Hoadonban.Tongtien = @tongtien AND dbo.ChitietHDB.Mahang = @mahang

)
GO

CREATE FUNCTION TimTheoMHNB(@mahang NVARCHAR(20),@ngayban DATE )
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE  dbo.Hoadonban.Ngayban = @ngayban  AND dbo.ChitietHDB.Mahang = @mahang

)
GO

CREATE FUNCTION TimTheoMHTT(@mahang NVARCHAR(20),@tongtien FLOAT )
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE    dbo.Hoadonban.Tongtien = @tongtien AND dbo.ChitietHDB.Mahang = @mahang

)
GO

CREATE FUNCTION TimTheoNBTT(@ngayban DATE,@tongtien FLOAT )
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.Hoadonban.Ngayban,dbo.Hoadonban.Tongtien
FROM dbo.ChitietHDB RIGHT JOIN dbo.Hoadonban ON Hoadonban.SoHDB = ChitietHDB.SoHDB
WHERE  dbo.Hoadonban.Ngayban = @ngayban AND dbo.Hoadonban.Tongtien = @tongtien 

)
GO


-- tao function tim kiem san pham trong ChitietHDN 
CREATE FUNCTION TimTheoSoHDN(@SoHDN INT)
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDN.SoHDN,dbo.ChitietHDN.Mahang,dbo.ChitietHDN.Soluong,dbo.ChitietHDN.Dongia,dbo.ChitietHDN.Giamgia,dbo.ChitietHDN.Thanhtien
FROM dbo.ChitietHDN
WHERE SoHDN = @SoHDN
)
GO
CREATE FUNCTION TimTheoMaHangNhap(@mahang NVARCHAR(20))
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDN.SoHDN,dbo.ChitietHDN.Mahang,dbo.ChitietHDN.Soluong,dbo.ChitietHDN.Dongia,dbo.ChitietHDN.Giamgia,dbo.ChitietHDN.Thanhtien
FROM dbo.ChitietHDN
WHERE Mahang = @mahang
)
GO
CREATE FUNCTION TimTheoSoHDNMaHang(@sohdn INT ,@mahang NVARCHAR(20))
RETURNS TABLE
AS
RETURN
(
SELECT dbo.ChitietHDN.SoHDN,dbo.ChitietHDN.Mahang,dbo.ChitietHDN.Soluong,dbo.ChitietHDN.Dongia,dbo.ChitietHDN.Giamgia,dbo.ChitietHDN.Thanhtien
FROM dbo.ChitietHDN
WHERE Mahang = @mahang AND SoHDN = @sohdn
)

GO

-- tao function tim kiem san pham trong ChitietHDB
CREATE FUNCTION TimTheoSoHDB (@SHDB INT )
RETURNS TABLE 
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.ChitietHDB.Soluong,dbo.ChitietHDB.Giamgia,dbo.ChitietHDB.Thanhtien
FROM dbo.ChitietHDB
WHERE SoHDB = @SHDB
)
GO
CREATE FUNCTION TimTheoMaHangBan (@mahang NVARCHAR(20))
RETURNS TABLE 
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.ChitietHDB.Soluong,dbo.ChitietHDB.Giamgia,dbo.ChitietHDB.Thanhtien
FROM dbo.ChitietHDB
WHERE Mahang = @mahang
)
GO
CREATE FUNCTION TimTheoSoHDBMahang (@shdb INT ,@mahang NVARCHAR(20))
RETURNS TABLE 
AS
RETURN
(
SELECT dbo.ChitietHDB.SoHDB,dbo.ChitietHDB.Mahang,dbo.ChitietHDB.Soluong,dbo.ChitietHDB.Giamgia,dbo.ChitietHDB.Thanhtien
FROM dbo.ChitietHDB
WHERE Mahang = @mahang AND SoHDB = @shdb
)

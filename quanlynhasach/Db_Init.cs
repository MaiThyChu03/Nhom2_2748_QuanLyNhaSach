using System;
using Microsoft.Data.Sqlite;
using System.IO;

namespace quanlynhasach
{
    public class Db_Init
    {

        public static void Initialize()
        {
            string dbPath = "nha_sach.db";

            if (!File.Exists(dbPath))
            {
                using var connection = new SqliteConnection($"Data Source={dbPath}");
                connection.Open();

                string sql = @"
                CREATE TABLE NguoiDung (
                    TenDN TEXT PRIMARY KEY,
                    HoTen TEXT NOT NULL,
                    MatKhau TEXT NOT NULL,
                    VaiTro TEXT NOT NULL CHECK (VaiTro IN ('QuanTri', 'NhanVien'))
                );

                CREATE TABLE TheLoai (
                    MaTL TEXT PRIMARY KEY,
                    TenTL TEXT
                );

                CREATE TABLE TacGia (
                    MaTG TEXT PRIMARY KEY,
                    TenTG TEXT
                );

                CREATE TABLE Sach (
                    MaSach TEXT PRIMARY KEY,
                    TenSach TEXT,
                    SoLuong INTEGER,
                    MaTL TEXT,
                    MaTG TEXT,
                    NguoiLap TEXT,
                    FOREIGN KEY (MaTL) REFERENCES TheLoai(MaTL),
                    FOREIGN KEY (MaTG) REFERENCES TacGia(MaTG),
                    FOREIGN KEY (NguoiLap) REFERENCES NguoiDung(TenDN)
                );

                CREATE TABLE KhachHang (
                    MaKH TEXT PRIMARY KEY,
                    HoTen TEXT,
                    DiaChi TEXT,
                    DienThoai TEXT,
                    Email TEXT,
                    NguoiLap TEXT,
                    FOREIGN KEY (NguoiLap) REFERENCES NguoiDung(TenDN)
                );

                CREATE TABLE HoaDon (
                    MaHD TEXT PRIMARY KEY,
                    MaKH TEXT,
                    NgayLap DATE,
                    NguoiLap TEXT,
                    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
                    FOREIGN KEY (NguoiLap) REFERENCES NguoiDung(TenDN)
                );

                CREATE TABLE CTHoaDon (
                    MaHD TEXT,
                    MaSach TEXT,
                    SoLuong INTEGER,
                    DonGia REAL,
                    PRIMARY KEY (MaHD, MaSach),
                    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
                    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
                );

                CREATE TABLE PhieuNhap (
                    MaPN TEXT PRIMARY KEY,
                    NgayNhap DATE,
                    NguoiLap TEXT,
                    FOREIGN KEY (NguoiLap) REFERENCES NguoiDung(TenDN)
                );

                CREATE TABLE CTPhieuNhap (
                    MaPN TEXT,
                    MaSach TEXT,
                    SoLuong INTEGER,
                    PRIMARY KEY (MaPN, MaSach),
                    FOREIGN KEY (MaPN) REFERENCES PhieuNhap(MaPN),
                    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
                );

                CREATE TABLE PhieuThuTien (
                    MaPT TEXT PRIMARY KEY,
                    MaKH TEXT,
                    NgayThu DATE,
                    SoTien REAL,
                    NguoiLap TEXT,
                    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
                    FOREIGN KEY (NguoiLap) REFERENCES NguoiDung(TenDN)
                );

                CREATE TABLE TonDauKy (
                    MaSach TEXT,
                    Ngay DATE,
                    SoLuong INTEGER,
                    PRIMARY KEY (MaSach, Ngay),
                    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
                );
            ";

                using var cmd = new SqliteCommand(sql, connection);
                cmd.ExecuteNonQuery();

                string createTonDauKy = @"
                    CREATE TABLE IF NOT EXISTS TonDauKy (
                        MaSach TEXT,
                        Ngay DATE,
                        SoLuong INTEGER,
                        PRIMARY KEY (MaSach, Ngay),
                        FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
                    );
                ";
                using (var cmdTonDauKy = new SqliteCommand(createTonDauKy, connection))
                {
                    cmdTonDauKy.ExecuteNonQuery();
                }

                string insertAdmin = @"
                    INSERT INTO NguoiDung (TenDN, HoTen, MatKhau, VaiTro)
                    VALUES ('admin', 'Quản trị viên', '123456', 'QuanTri');
                ";

                using var insertCmd = new SqliteCommand(insertAdmin, connection);
                insertCmd.ExecuteNonQuery();
            }
        }
    }
}

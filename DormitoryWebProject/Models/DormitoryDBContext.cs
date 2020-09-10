using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DormitoryWebProject.Models
{
    public class DormitoryDBContext : DbContext
    {
        public DormitoryDBContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<KTX> KTX { get; set; }
        public DbSet<ChiTietKTX> ChiTietKTX { get; set; }

        public DbSet<Tang> Tang { get; set; }
        public DbSet<Loai> Loai { get; set; }

        public DbSet<Phong> Phong { get; set; }
        public DbSet<ChiTietPhong> ChiTietPhong { get; set; }

        public DbSet<ChucVu> ChucVu { get; set; }

        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }

        public DbSet<SinhVien> SinhVien { get; set; }

        public DbSet<Poster> Poster { get; set; }
        public DbSet<NhanXetKhachHang> NhanXetKhachHang { get; set; }

        public DbSet<HoaDonDienNuoc> HoaDonDienNuoc { get; set; }
        public DbSet<HoaDonLePhi> HoaDonLePhi { get; set; }

        public DbSet<VatTu> VatTu { get; set; }
        public DbSet<LoaiVatTu> LoaiVatTu { get; set; }
        public DbSet<NhanHieu> NhanHieu { get; set; }

        public DbSet<PhieuGiatSay> PhieuGiatSay { get; set; }
        public DbSet<ChiTietPhieuGiat> ChiTietPhieuGiat { get; set; }

        public DbSet<YeuCauSuaChua> YeuCauSuaChua { get; set; }
        public DbSet<ChiTietYCSC> ChiTietYCSC { get; set; }

        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<User> User { get; set; }

    }
}
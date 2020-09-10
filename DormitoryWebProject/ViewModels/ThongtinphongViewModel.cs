using DormitoryWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DormitoryWebProject.ViewModels
{
    public class ThongtinphongViewModel
    {
        public List<Phong> LISTPhong { get; set; }
        public List<Tang> LISTTang { get; set; }
        public List<KTX> LISTKTX { get; set; }
        public List<Loai> LISTLoai { get; set; }
        public List<ChiTietPhong> LISTChiTiet { get; set; }
        public List<SinhVien> LISTSinhVien { get; set; }
        public List<Khoa> LISTKhoa { get; set; }
        public List<ChiTietPhong> LISTChiTietPhong { get; set; }
        public List<ChucVu> LISTChucVu { get; set; }
        public int soluongsinhvien { get; set; }
    }
}
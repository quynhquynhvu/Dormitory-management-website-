using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DormitoryWebProject.Models
{
    //===========================PRIMARY===========================

    [Table("KTX")]
    public class KTX
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã KTX")]
        public int MaKTX { get; set; }

        //Các thuộc tính
        [DisplayName("Tên KTX")]
        public string TenKTX { get; set; }

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Số điện thoại liên hệ")]
        public int SDTLienHe { get; set; }

        public string Email { get; set; }

        //Quan hệ
        public virtual ICollection<Phong> Phong { get; set; }
        public virtual ICollection<ChiTietKTX> ChiTietKTX { get; set; }
        public virtual ICollection<PhieuGiatSay> PhieuGiatSay { get; set; }
    }

    [Table("ChiTietKTX")]
    public class ChiTietKTX
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã chi tiết KTX")]
        public int MaChiTietKTX { get; set; }

        //Các thuộc tính
        [DisplayName("Đánh giá")]
        [Range(1, 5)]
        public double Rated { get; set; }

        [DisplayName("Giá thuê thấp nhất")]
        public double GiaThueThapNhat { get; set; }

        [DisplayName("Giá thuê cao nhất")]
        public double GiaThueCaoNhat { get; set; }

        [DisplayName("Mô tả KTX")]
        [MinLength(200, ErrorMessage = "Độ dài mô tả tối thiểu 200 kí tự!")]
        public string MoTaKTX { get; set; }

        public string picturePath1 { get; set; }
        public string picturePath2 { get; set; }
        public string picturePath3 { get; set; }
        public string picturePath4 { get; set; }
        public string picturePath5 { get; set; }

        //Khóa ngoại
        [ForeignKey("KTX")]
        [DisplayName("Kí túc xá")]
        public int MaKTX { get; set; }

        //Khác
        [NotMapped]
        [DisplayName("Hình ảnh KTX 1")]
        public HttpPostedFileBase pictureUpload1 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh KTX 2")]
        public HttpPostedFileBase pictureUpload2 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh KTX 3")]
        public HttpPostedFileBase pictureUpload3 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh KTX 4")]
        public HttpPostedFileBase pictureUpload4 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh KTX 5")]
        public HttpPostedFileBase pictureUpload5 { get; set; }

        //Quan hệ
        public virtual KTX KTX { get; set; }
    }

    [Table("Tang")]
    public class Tang
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã tầng")]
        public int MaTang { get; set; }

        //Các thuộc tính
        [DisplayName("Tên")]
        public string Ten { get; set; }

        //Quan hệ
        public virtual ICollection<Phong> Phong { get; set; }
    }

    [Table("Loai")]
    public class Loai
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã loại")]
        public int MaLoai { get; set; }

        //Các thuộc tính
        [DisplayName("Tên loại")]
        public string TenLoai { get; set; }

        [DisplayName("Giá thuê/người")]
        public double GiaThue { get; set; }

        [DisplayName("Giá điện/kwh")]
        public double GiaDien { get; set; }

        [DisplayName("Giá nước/người")]
        public double GiaNuoc { get; set; }

        //Quan hệ
        public virtual ICollection<Phong> Phong { get; set; }
    }

    [Table("ChucVu")]
    public class ChucVu
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã chức vụ")]
        public int MaChucVu { get; set; }

        //Các thuộc tính
        [DisplayName("Tên chức vụ")]
        public string TenChucVu { get; set; }

        //Quan hệ
        public virtual ICollection<ChiTietPhong> ChiTietPhong { get; set; }
    }

    [Table("Khoa")]
    public class Khoa
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã ID")]
        public int MaKhoa { get; set; }

        //Các thuộc tính
        [DisplayName("Tên khoa")]
        public string TenKhoa { get; set; }

        //Quan hệ
        public virtual ICollection<Lop> Lop { get; set; }
    }

    [Table("KhoaHoc")]
    public class KhoaHoc
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã ID")]
        public int MaKhoaHoc { get; set; }

        //Các thuộc tính
        [DisplayName("Khóa học")]
        public string TenKhoaHoc { get; set; }

        //Quan hệ
        public virtual ICollection<SinhVien> SinhVien { get; set; }
        public virtual ICollection<NhanXetKhachHang> NhanXetKhachHang { get; set; }
    }

    [Table("Lop")]
    public class Lop
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã ID")]
        public int MaLop { get; set; }

        //Các thuộc tính
        [DisplayName("Mã lớp")]
        public string TenLop { get; set; }

        //Khóa ngoại
        [ForeignKey("Khoa")]
        public int MaKhoa { get; set; }

        //Quan hệ
        public virtual Khoa Khoa { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }

    [Table("Phong")]
    public class Phong
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã phòng")]
        public int MaPhong { get; set; }

        //Các thuộc tính
        [DisplayName("Tên phòng")]
        public string TenPhong { get; set; }

        [DisplayName("Tổng số giường")]
        public int TongSoGiuong { get; set; }

        [DisplayName("Cơ sở vật chất")]
        public string CoSoVatChat { get; set; }

        public string picturePath1 { get; set; }
        public string picturePath2 { get; set; }
        public string picturePath3 { get; set; }
        public string picturePath4 { get; set; }
        public string picturePath5 { get; set; }

        //Khác
        [NotMapped]
        [DisplayName("Hình ảnh phòng 1")]
        public HttpPostedFileBase pictureUpload1 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh phòng 2")]
        public HttpPostedFileBase pictureUpload2 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh phòng 3")]
        public HttpPostedFileBase pictureUpload3 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh phòng 4")]
        public HttpPostedFileBase pictureUpload4 { get; set; }
        [NotMapped]
        [DisplayName("Hình ảnh phòng 5")]
        public HttpPostedFileBase pictureUpload5 { get; set; }

        //Khóa ngoại
        [ForeignKey("KTX")]
        public int MaKTX { get; set; }
        [ForeignKey("Tang")]
        public int MaTang { get; set; }
        [ForeignKey("Loai")]
        public int MaLoai { get; set; }

        //Quan hệ
        public virtual KTX KTX { get; set; }
        public virtual Tang Tang { get; set; }
        public virtual Loai Loai { get; set; }

        public ICollection<ChiTietKTX> ChiTietKTX { get; set; }
        public ICollection<HoaDonLePhi> HoaDonLePhi { get; set; }
        public ICollection<HoaDonDienNuoc> HoaDonDienNuoc { get; set; }
        public ICollection<YeuCauSuaChua> YeuCauSuaChua { get; set; }
    }

    [Table("ChiTietPhong")]
    public class ChiTietPhong
    {
        //Khóa chính
        [Key]
        [ForeignKey("SinhVien")]
        [DisplayName("Mã CTP")]
        public int MaChiTietPhong { get; set; }

        //Các thuộc tính
        [DisplayName("Ngày vào")]
        public DateTime NgayVao { get; set; }

        //Khóa ngoại
        [ForeignKey("Phong")]
        public int MaPhong { get; set; }

        [ForeignKey("ChucVu")]
        public int MaChucVu { get; set; }

        //Quan hệ
        public virtual Phong Phong { get; set; }    
        public virtual ChucVu ChucVu { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }

    [Table("SinhVien")]
    public class SinhVien
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã sinh viên")]
        public int MSSV { get; set; }

        //Các thuộc tính
        [DisplayName("Tên sinh viên")]
        public string TenSV { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Số CMND")]
        public string CMND { get; set; }

        [DisplayName("Số điện thoại")]
        public int SDT { get; set; }

        [DisplayName("Quê quán")]
        public string QueQuan { get; set; }

        [DisplayName("Địa chỉ thường trú")]
        public string DiaChiThuongTru { get; set; }

        [DisplayName("Giới tính")]
        public bool GioiTinh { get; set; }

        public string piturePath { get; set; }

        //Khác
        [NotMapped]
        [DisplayName("Hình ảnh cá nhân")]
        public HttpPostedFileBase pitureUpload { get; set; }

        //Khóa ngoại
        [ForeignKey("KhoaHoc")]
        public int MaKhoaHoc { get; set; }
        [ForeignKey("Lop")]
        public int MaLop { get; set; }

        //Quan hệ
        public virtual KhoaHoc KhoaHoc { get; set; }
        public virtual Lop Lop { get; set; }

        public virtual ICollection<ChiTietPhieuGiat> ChiTietPhieuGiat { get; set; }
        public virtual ChiTietPhong ChiTietPhong { get; set; }
        public ICollection<HoaDonLePhi> HoaDonLePhi { get; set; }
        public ICollection<YeuCauSuaChua> YeuCauSuaChua { get; set; }
    }

    [Table("PhieuGiatSay")]
    public class PhieuGiatSay
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã phiếu giặt")]
        public int MaPhieuGiat { get; set; }

        //Các thuộc tính
        [DisplayName("Thành tiền")]
        public double ThanhTien { get; set; }

        [DisplayName("Trạng thái")]
        public string TrangThai { get; set; }

        [DisplayName("Ngày nhận")]
        public DateTime NgayNhan { get; set; }

        [DisplayName("Ngày trả dự kiến")]
        public DateTime NgayTraDuKien { get; set; }

        //Khóa ngoại
        [ForeignKey("KTX")]
        public int MaKTX { get; set; }

        //Quan hệ
        public virtual KTX KTX { get; set; }

        public virtual ICollection<ChiTietPhieuGiat> ChiTietPhieuGiat { get; set; }
    }

    [Table("ChiTietPhieuGiat")]
    public class ChiTietPhieuGiat
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã chi tiết")]
        public int MaChiTietPhieuGiat { get; set; }

        //Các thuộc tính
        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Đơn giá")]
        public double DonGia { get; set; }

        //Khóa ngoại
        [ForeignKey("SinhVien")]
        public int MSSV { get; set; }
        [ForeignKey("PhieuGiatSay")]
        public int MaPhieuGiat { get; set; }
        
        //Quan hệ
        public virtual SinhVien SinhVien { get; set; }
        public virtual PhieuGiatSay PhieuGiatSay { get; set; }
    }

    [Table("HoaDonLePhi")]
    public class HoaDonLePhi
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã hóa đơn")]
        public int MaHoaDonLePhi { get; set; }

        //Các thuộc tính
        [DisplayName("Học kỳ đóng")]
        public string HocKyDong { get; set; }

        [DisplayName("Năm đóng")]
        public int NamDong { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Đơn giá")]
        public double DonGia { get; set; }

        [DisplayName("Thành tiền")]
        public double ThanhTien { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime NgayTao { get; set; }

        //Khóa ngoại
        [ForeignKey("Phong")]
        public int MaPhong { get; set; }
        [ForeignKey("SinhVien")]
        public int MSSV { get; set; }

        //Quan hệ
        public virtual Phong Phong { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }

    [Table("HoaDonDienNuoc")]
    public class HoaDonDienNuoc
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã hóa đơn")]
        public int MaHoaDonDienNuoc { get; set; }

        //Các thuộc tính
        [DisplayName("Tháng đóng")]
        public string ThangDong { get; set; }

        [DisplayName("Số Kwh")]
        public int SoKwh { get; set; }

        [DisplayName("Thành tiền")]
        public double ThanhTien { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime NgayTao { get; set; }

        //Khóa ngoại
        [ForeignKey("Phong")]
        public int MaPhong { get; set; }

        //Quan hệ
        public virtual Phong Phong { get; set; }
    }

    [Table("YeuCauSuaChua")]
    public class YeuCauSuaChua
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã yêu cầu")]
        public int MaYeuCauSuaChua { get; set; }

        //Các thuộc tính
        [DisplayName("Nội dung")]
        public string NoiDung { get; set; }
        [DisplayName("Ngày gửi")]
        public DateTime NgayGui { get; set; }

        //Khóa ngoại
        [ForeignKey("SinhVien")]
        public int MSSV { get; set; }
        [ForeignKey("Phong")]
        public int MaPhong { get; set; }

        //Quan hệ
        public virtual SinhVien SinhVien { get; set; }
        public virtual Phong Phong { get; set; }

        public virtual ChiTietYCSC ChiTietYCSC { get; set; }
    }

    [Table("ChiTietYCSC")]
    public class ChiTietYCSC
    {
        //Khóa chính
        [Key]
        [ForeignKey("YeuCauSuaChua")]
        [DisplayName("Mã chi tiết YCSC")]
        public int MaChiTietYCSC { get; set; }

        //Các thuộc tính
        [DisplayName("Trạng thái")]
        public string TrangThai { get; set; }

        [DisplayName("Tên nhân viên")]
        public string TenNhanVien { get; set; }

        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Đơn giá")]
        public double DonGia { get; set; }

        [DisplayName("Thành tiền")]
        public double ThanhTien { get; set; }

        [DisplayName("Ngày sửa")]
        public DateTime NgaySua { get; set; }

        //Khóa ngoại
        [ForeignKey("VatTu")]
        public int MaVatTu { get; set; }

        //Quan hệ
        public virtual VatTu VatTu { get; set; }

        public virtual YeuCauSuaChua YeuCauSuaChua { get; set; }
    }

    [Table("VatTu")]
    public class VatTu
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã vật tư")]
        public int MaVatTu { get; set; }

        //Các thuộc tính
        [DisplayName("Tên vật tư")]
        public string TenVatTu { get; set; }

        [DisplayName("Đơn giá")]
        public int DonGia { get; set; }

        [DisplayName("Số lượng tồn")]
        public int SoLuongTonKho { get; set; }

        [DisplayName("Ngày nhập kho")]
        public DateTime NgayNhapKho { get; set; }

        //Khóa ngoại
        [ForeignKey("LoaiVatTu")]
        public int MaLoaiVatTu { get; set; }
        [ForeignKey("NhanHieu")]
        public int MaNhanHieu { get; set; }

        //Quan hệ
        public virtual LoaiVatTu LoaiVatTu { get; set; }
        public virtual NhanHieu NhanHieu { get; set; }
        public ICollection<ChiTietYCSC> ChiTietYCSC { get; set; }
    }

    [Table("LoaiVatTu")]
    public class LoaiVatTu
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã loại vật tư")]
        public int MaLoaiVatTu { get; set; }

        //Các thuộc tính
        [DisplayName("Tên loại vật tư")]
        public string TenLoaiVatTu { get; set; }

        [DisplayName("Đơn vị tính")]
        public string DonViTinh { get; set; }

        //Quan hệ
        public ICollection<VatTu> VatTu { get; set; }
    }

    [Table("NhanHieu")]
    public class NhanHieu
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã nhãn hiệu")]
        public int MaNhanHieu { get; set; }

        //Các thuộc tính
        [DisplayName("Tên nhãn hiệu")]
        public string TenNhanHieu { get; set; }

        //Quan hệ
        public ICollection<VatTu> VatTu { get; set; }
    }

    //===========================USER AND ROLE===========================

    [Table("VaiTro")]
    public class VaiTro
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã vai trò")]
        public int MaVaiTro { get; set; }

        //Các thuộc tính
        [DisplayName("Tên vai trò")]
        public string TenVaiTro { get; set; }

        [DisplayName("Mô tả")]
        public string MoTa { get; set; }

        //Quan hệ
        public ICollection<User> User { get; set; }
    }

    [Table("User")]
    public class User
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã người dùng")]
        public int MaUser { get; set; }

        //Các thuộc tính
        [DisplayName("Họ")]
        public string Ho { get; set; }

        [DisplayName("Tên")]
        public string Ten { get; set; }

        [DisplayName("Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Số lần Login")]
        public int SoLanLogin { get; set; }

        [DisplayName("Lần đăng nhập cuối")]
        public DateTime LastLogin { get; set; }

        //Khóa ngoại
        [ForeignKey("VaiTro")]
        public int MaVaitro { get; set; }

        //Quan hệ
        public virtual VaiTro VaiTro { get; set; }
    }

    //===========================APPENDIX================================

    [Table("Poster")]
    public class Poster
    {
        //Khóa chính
        [Key]
        [DisplayName("Mã ID")]
        public int MaPoster { get; set; }

        //Các thuộc tính
        [Required]
        public string Caption { get; set; }

        [DisplayName("Ngày sửa cuối cùng")]
        public DateTime LastModified { get; set; }

        public string picturePath { get; set; }

        //Khác
        [NotMapped]
        [DisplayName("Hình ảnh")]
        public HttpPostedFileBase pictureUpload { get; set; }
    }

    [Table("NhanXetKhachHang")]
    public class NhanXetKhachHang
    {
        //Khóa chính
        [Key]
        public int MaNhanXet { get; set; }

        //Các thuộc tính
        [DisplayName("Tên khách hàng")]
        public string TenKhachHang { get; set; }

        [DisplayName("Bình luận")]
        public string BinhLuan { get; set; }

        [DisplayName("Công việc")]
        public string CongViec { get; set; }

        [DisplayName("Đánh giá")]
        [Range(1, 5)]
        public double Rated { get; set; }

        public string picturePath { get; set; }

        //Khác
        [NotMapped]
        [DisplayName("Hình ảnh cá nhân")]
        public HttpPostedFileBase pictureUpload { get; set; }

        //Khóa ngoại
        [ForeignKey("KhoaHoc")]
        public int MaKhoaHoc { get; set; }

        //Quan hệ
        public virtual KhoaHoc KhoaHoc { get; set; }
    }
}
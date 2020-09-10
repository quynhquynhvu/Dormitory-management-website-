using DormitoryWebProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace DormitoryWebProject.ViewModels
{
    public class TrangChuViewModel
    {
        public List<KTX> LISTKTX { get; set; }
        public List<ChiTietKTX> LISTChiTietKTX { get;set; }
        public List<Poster> LISTPoster { get; set; }
        public List<NhanXetKhachHang> LISTNhanXetKhachHang { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_Dtos.SanPhamsDtos
{
    public class SanPham
    {
        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public float DongGiaBan { get; set; }
        public float DongGiaNhap { get; set; }
        public string HinhAnh { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
        public string MaNV { get; set; }
    }
}

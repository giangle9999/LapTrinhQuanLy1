using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiTapLonn136.Models
{
    [Table("Nhập Kho")]
    public class NhapKho
    {
        [Key]
        [Display(Name = "Mã Phiếu Nhập")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string MaPhieuNhap { get; set; }

        [Display(Name = "Ngày Nhập")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string NgayNhap { get; set; }

        [Display(Name = "Mã Hàng")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string MaHang { get; set; }

        [Display(Name = "Tên Hàng")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string TenHang { get; set; }

        [Display(Name = "Số Lượng")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public int SoLuong { get; set; }

        [Display(Name = "Đơn Giá")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public int DonGia { get; set; }

        [Display(Name = "Thành Tiền")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public int ThanhTien { get; set; }
    }
}
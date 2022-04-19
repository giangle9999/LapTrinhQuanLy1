using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiTapLonn136.Models
{
    [Table("Tồn Kho")]
    public class TonKho
    {
        [Key]
        [Display(Name = "Mã Hàng Tồn")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string MaHangTon { get; set; }

        [Display(Name = "Tên Hàng")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string TenHang { get; set; }

        [Display(Name = "Số Lượng")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public int SoLuong { get; set; }
    }
}
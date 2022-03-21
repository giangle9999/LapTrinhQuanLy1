using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiTapLonn136.Models
{
    [Table("Hàng Hóa")]
    public class HangHoa
    {
        [Key]
        [Display(Name = "Mã Hàng")]
        public string MaHang { get; set; }

        [Display(Name = "Tên Hàng")]
        public string TenHang { get; set; }

        [Display(Name = "Số Lượng")]
        public int SoLuong { get; set; }

        [Display(Name = "Đơn Giá")]
        public int DonGia { get; set; }
    }
}
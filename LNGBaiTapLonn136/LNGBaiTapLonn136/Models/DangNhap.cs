using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiTapLonn136.Models
{
    [Table("DangNhap")]
    public class DangNhap
    {
        [Key]
        [Display(Name = "Tên Đăng Nhập")]
        public string TenDangNhap { get; set; }


        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }
    }
}
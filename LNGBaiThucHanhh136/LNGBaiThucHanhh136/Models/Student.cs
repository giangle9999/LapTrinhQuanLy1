using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LNGBaiThucHanhh136.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string TenSinhVien { get; set; }
        public string MaSinhvien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
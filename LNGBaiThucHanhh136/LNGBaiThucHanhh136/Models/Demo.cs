using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LNGBaiThucHanhh136.Models
{
    public partial class Demo : DbContext
    {
        public Demo()
            : base("name=Demo")
        {
        }

        
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQLBT.Models
{
    public partial class LapTrinhQuanLyDBConText : DbContext
    {
        public LapTrinhQuanLyDBConText()
            : base("name=LapTrinhQuanLyDBConText")
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
              .Property(e => e.SodienThoai)
              .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
               .Property(e => e.idKhachHang)
               .IsUnicode(false);
        }
    }
}

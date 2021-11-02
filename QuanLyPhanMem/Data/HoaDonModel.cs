using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace from_thong_ke
{
    public partial class HoaDonModel : DbContext
    {
        public HoaDonModel()
            : base("name=HoaDonModel")
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);
        }
    }
}

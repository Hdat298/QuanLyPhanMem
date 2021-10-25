namespace from_thong_ke
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLapHoaDon { get; set; }

        public int? TongGia { get; set; }

        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaKhachHang { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyPhanMem
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public Nullable<System.DateTime> NgayLapHoaDon { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLaptop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhGia
    {
        public string MaDG { get; set; }
        public string MaSP { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> DiemDanhGia { get; set; }
        public string NhanXet { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual UsSer UsSer { get; set; }
    }
}

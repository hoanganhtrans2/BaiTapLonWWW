//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDoAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class SinhVien
    {
        public string maSinhVien { get; set; }
        public string tenSinhVien { get; set; }
        public string email { get; set; }
        public string soDienThoai { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string maDeTai { get; set; }
    
        public virtual DeTai DeTai { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}

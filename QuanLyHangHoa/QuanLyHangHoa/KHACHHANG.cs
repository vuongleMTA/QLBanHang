//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHangHoa
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.XUATs = new HashSet<XUAT>();
        }
    
        public int KHACHHANGID { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<int> GIOITINH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
    
        public virtual ICollection<XUAT> XUATs { get; set; }
    }
}

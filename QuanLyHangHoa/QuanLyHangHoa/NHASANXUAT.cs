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
    
    public partial class NHASANXUAT
    {
        public NHASANXUAT()
        {
            this.MATHANGs = new HashSet<MATHANG>();
        }
    
        public int NHASANXUATID { get; set; }
        public string TEN { get; set; }
        public Nullable<int> NAMTHANHLAP { get; set; }
    
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
    }
}
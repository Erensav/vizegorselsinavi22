//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vizegorselsinavi22.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ogrenciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ogrenciler()
        {
            this.tbl_ogretmen1 = new HashSet<tbl_ogretmen>();
        }
    
        public int ogrenciid { get; set; }
        public string ogrenciAdSoyadi { get; set; }
        public Nullable<int> ogrenciNo { get; set; }
        public Nullable<bool> ogrenciMezun { get; set; }
        public Nullable<int> ogrenciKredi { get; set; }
        public string admin { get; set; }
        public string password { get; set; }
        public Nullable<int> notc { get; set; }
        public string ogrencimail { get; set; }
        public Nullable<int> bolumid { get; set; }
        public string ogrencibolum { get; set; }
    
        public virtual tbl_ogretmen tbl_ogretmen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ogretmen> tbl_ogretmen1 { get; set; }
    }
}

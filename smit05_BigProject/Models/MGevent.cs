//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace smit05_BigProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MGevent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MGevent()
        {
            this.MGsellerSigns = new HashSet<MGsellerSign>();
            this.MGsellerSigns1 = new HashSet<MGsellerSign>();
            this.MGwishlists = new HashSet<MGwishlist>();
        }
    
        public int E_ID { get; set; }
        public int M_ID { get; set; }
        public string E_name { get; set; }
        public string E_time_start { get; set; }
        public string E_time_end { get; set; }
        public string E_regist_time_start { get; set; }
        public string E_regist_time_end { get; set; }
        public string E_address { get; set; }
        public string E_peopleWho { get; set; }
        public string E_unitInstock { get; set; }
        public string E_detail { get; set; }
        public string E_LOGO_L { get; set; }
        public string E_LOGO_S { get; set; }
        public string E_NL_L1 { get; set; }
        public string E_NL_L2 { get; set; }
        public string E_NL_L3 { get; set; }
        public string E_NL_L4 { get; set; }
        public string E_NL_L5 { get; set; }
        public string E_NL_L6 { get; set; }
        public string E_NL_L7 { get; set; }
        public string E_NL_L8 { get; set; }
        public string E_NL_L9 { get; set; }
        public string E_NL_L10 { get; set; }
        public string OE_I1 { get; set; }
        public string OE_I2 { get; set; }
        public string OE_I3 { get; set; }
        public string OE_I4 { get; set; }
        public string OE_I5 { get; set; }
        public string OE_I6 { get; set; }
        public string OE_FB { get; set; }
    
        public virtual MGmember MGmember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MGsellerSign> MGsellerSigns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MGsellerSign> MGsellerSigns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MGwishlist> MGwishlists { get; set; }
    }
}

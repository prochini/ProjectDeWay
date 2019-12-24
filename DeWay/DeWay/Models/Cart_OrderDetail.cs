//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeWay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DeWay.Models.Metadata;

    [MetadataType(typeof(MetadataCart_OrderDetail))]
    public partial class Cart_OrderDetail
    {
        public string cartID { get; set; }
        public string mbrID { get; set; }
        public string spcID { get; set; }
        public string odrID { get; set; }
        public int Quantity { get; set; }
        public Nullable<double> Discount { get; set; }
        public int usedPoints { get; set; }
        public string shpID { get; set; }
        public Nullable<decimal> pdtPrice { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual Order Order { get; set; }
        public virtual Specification Specification { get; set; }
    }
}

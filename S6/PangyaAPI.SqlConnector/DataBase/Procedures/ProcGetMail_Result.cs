//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PangyaAPI.SqlConnector.DataBase.Procedures
{
    using System;
    
    public partial class ProcGetMail_Result
    {
        public Nullable<int> PAGE_TOTAL { get; set; }
        public int Mail_Index { get; set; }
        public string Sender { get; set; }
        public int IsRead { get; set; }
        public Nullable<int> TYPEID { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<int> IsTimer { get; set; }
        public Nullable<short> DAY { get; set; }
        public string UCC_UNIQUE { get; set; }
        public Nullable<int> SETTYPEID { get; set; }
        public Nullable<int> Mail_Item_Count { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.Domain
{
    using System;
    
    public partial class sp_Permission_GetMenuList_Result
    {
        public int MenuID { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int Status { get; set; }
        public Nullable<int> EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDatetime { get; set; }
        public Nullable<int> OrderSerial { get; set; }
        public string Roles { get; set; }
    }
}

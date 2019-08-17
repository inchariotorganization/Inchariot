using System;
using System.Collections.Generic;

namespace Inchariot.DAL.Models
{
    public partial class Registration
    {
        public System.Guid RID { get; set; }
        public string Name { get; set; }
        public Nullable<int> MobileNo { get; set; }
        public Nullable<int> OTP { get; set; }
        public string Email { get; set; }
        public string Gander { get; set; }
        public Nullable<int> Dateofbirth { get; set; }
        public string Photo { get; set; }
        public Nullable<System.DateTime> DateOn { get; set; }
    }
}

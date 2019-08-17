using System;
using System.Collections.Generic;

namespace Inchariot.DAL.Models
{
    public partial class ProfileChange
    {
        public System.Guid PID { get; set; }
        public Nullable<System.Guid> UID { get; set; }
        public byte[] firstName { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public Nullable<int> datebirth { get; set; }
        public string bio { get; set; }
        public string profilephoto { get; set; }
        public virtual aspnet_Profile aspnet_Profile { get; set; }
    }
}

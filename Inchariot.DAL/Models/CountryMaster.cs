using System;
using System.Collections.Generic;

namespace Inchariot.DAL.Models
{
    public partial class CountryMaster
    {
        public System.Guid CountryID { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}

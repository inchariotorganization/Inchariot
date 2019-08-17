using System;
using System.Collections.Generic;

namespace Inchariot.DAL.Models
{
    public partial class Table
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}

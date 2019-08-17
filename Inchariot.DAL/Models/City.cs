using System;
using System.Collections.Generic;

namespace Inchariot.DAL.Models
{
    public partial class City
    {
        public string Id { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}

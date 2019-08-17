using System;
using System.Collections.Generic;

namespace Inchariot.DAL.Models
{
    public partial class RideShare
    {
        public string Id { get; set; }
        public string MemberCardId { get; set; }
        public Nullable<System.DateTime> TravelStartTime { get; set; }
        public string SourceCityId { get; set; }
        public string DestinationCityId { get; set; }
        public Nullable<int> SeatsOffered { get; set; }
        public Nullable<decimal> ContributionPerHead { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> AC { get; set; }
        public string Vehicle { get; set; }
       
    }
}

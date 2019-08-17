using System;

namespace Inchariot.BAL.ViewModels
{
    public class RideShareViewModel
    {
    }

    public class CreateRideViewModel
    {
        public string MemberCarId { get; set; }
        public Nullable<System.DateTime> TravelStartTime { get; set; }
        public string SourceCity { get; set; }
        public string SourceCityId { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationCityId { get; set; }
        public Nullable<int> SeatsOffered { get; set; }
        public Nullable<decimal> ContributionPerHead { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> AC { get; set; }
        public string Vehicle { get; set; }
    }
}

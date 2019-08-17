using Inchariot.BAL.ViewModels;
using Inchariot.DAL.Models;
using System;

namespace Inchariot.BAL.Repository
{
    public class RideShareRepository
    {
        IncharoitAPIContext db = new IncharoitAPIContext();
        public bool SaveShare(CreateRideViewModel createRideViewModel)
        {
            RideShare rideShare = new RideShare();
            rideShare.AC = createRideViewModel.AC;
            rideShare.ContributionPerHead = createRideViewModel.ContributionPerHead;
            rideShare.CreatedOn = createRideViewModel.CreatedOn;
            rideShare.DestinationCityId = createRideViewModel.DestinationCityId;
            rideShare.Id = Guid.NewGuid().ToString();
            rideShare.TravelStartTime = createRideViewModel.TravelStartTime;
            rideShare.Vehicle = createRideViewModel.Vehicle;
            rideShare.SeatsOffered = createRideViewModel.SeatsOffered;
            rideShare.MemberCardId = createRideViewModel.MemberCarId;
            db.RideShares.Add(rideShare);
            City city = new City();
            city.CityName = createRideViewModel.SourceCity;
            city.Id = createRideViewModel.SourceCityId;
            db.Cities.Add(city);
            city.CityName = createRideViewModel.DestinationCity;
            city.Id = createRideViewModel.DestinationCityId;
            db.Cities.Add(city);
            db.SaveChanges();
            return true;
        }

        public void Method()
        {
        }


    }
}

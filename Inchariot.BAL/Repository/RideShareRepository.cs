using Inchariot.BAL.ViewModels;
using Inchariot.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            rideShare.SourceCity = createRideViewModel.SourceCity;
            rideShare.DestinationCity = createRideViewModel.DestinationCity;
            rideShare.Id = Guid.NewGuid().ToString();
            rideShare.TravelStartTime = createRideViewModel.TravelStartTime;
            rideShare.Vehicle = createRideViewModel.Vehicle;
            rideShare.SeatsOffered = createRideViewModel.SeatsOffered;
            rideShare.MemberCardId = createRideViewModel.MemberCarId;
            db.RideShares.Add(rideShare);
            db.SaveChanges();
            return true;
        }


        public List<ViewModels.VehicleType> GetVehicleType()
        {
            List<ViewModels.VehicleType> model = new List<ViewModels.VehicleType>();
            var list = db.VehicleTypes.ToList();
            foreach (var item in list)
            {
                model.Add(new ViewModels.VehicleType {Id=item.Id, Type=item.VehicleType1 });
            }
            return model;
        }


    }
}

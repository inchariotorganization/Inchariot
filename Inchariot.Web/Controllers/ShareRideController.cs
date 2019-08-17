using Inchariot.BAL.Repository;
using Inchariot.BAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inchariot.Web.Controllers
{
    public class ShareRideController : Controller
    {
        RideShareRepository rideShareRepository;
        public ShareRideController()
        {
            rideShareRepository = new RideShareRepository();
        }
        // GET: ShareRide
        public ActionResult Index()
        {
            CreateRideViewModel createRideViewModel = new CreateRideViewModel();
            createRideViewModel.VehicleList = rideShareRepository.GetVehicleType();
            return View(createRideViewModel);
        }

        // GET: ShareRide
        [HttpPost]
        public ActionResult Share(CreateRideViewModel createRideViewModel)
        {
            rideShareRepository.SaveShare(createRideViewModel);
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class Engine
    {
        UI view = new UI();
        public List<Cab> AllCabs = new List<Cab>();
        public List<District> AllDistrict = new List<District>();

        public void changeCabStatus(Cab cab)
        {
            if (cab.Status == false) {
                cab.Status = true;
            } else {
                cab.Status = false;
            }
        }

        public void sendCab(District district)
        {
            if (district.Cabs.Count > 0) {
                this.changeCabStatus(district.Cabs[0]);
            } else {

            }
        }

        public void loadAllCabs()
        {
            AllCabs = new List<Cab>() {
                new Cab() { Id = 1, Name = "Ford Mondeo", DistrictId = 1, Status = false},
                new Cab() { Id = 2, Name = "Dacia Logan", DistrictId = 2, Status = false},
                new Cab() { Id = 3, Name = "Toyota Avensis", DistrictId = 3, Status = false},
                new Cab() { Id = 4, Name = "Mercedes E220", DistrictId = 4, Status = false},
                new Cab() { Id = 5, Name = "Huindai Lantra", DistrictId = 5, Status = false}
            };
        }

        public void loadAllDistricts()
        {
            AllDistrict = new List<District>() {
                new District(AllCabs, 1) { Name = "Retkinia", Distancetocenter = -2 },
                new District(AllCabs, 2) { Name = "Łódź Kaliska", Distancetocenter = -1 },
                new District(AllCabs, 3) { Name = "Śródmieście", Distancetocenter = 0 },
                new District(AllCabs, 4) { Name = "Widzew", Distancetocenter = 1 },
                new District(AllCabs, 5) { Name = "Janów", Distancetocenter = 3 },
            };
        }

        public bool controll()
        {
            // if () ;
            view.loadView();
            // view.loadView(AllDistrict);
            return false;
        }


    }
}

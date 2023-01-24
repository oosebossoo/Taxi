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
                new Cab() { Id = 1, Name = "Opel", DistrictId = 1, Status = false},
                new Cab() { Id = 2, Name = "Ferrari", DistrictId = 2, Status = false},
                new Cab() { Id = 3, Name = "Ferrari", DistrictId = 3, Status = false},
                new Cab() { Id = 4, Name = "Ferrari", DistrictId = 4, Status = false},
                new Cab() { Id = 5, Name = "Ferrari", DistrictId = 5, Status = false}
            };
        }

        public void loadAllDistricts()
        {
            AllDistrict = new List<District>() {
                new District(AllCabs, 1) { Name = "Łódź", Distancetocenter = -2},
                new District(AllCabs, 2) { Name = "Warszawa", Distancetocenter = -2 },
                new District(AllCabs, 3) { Name = "Warszawa", Distancetocenter = -2 },
                new District(AllCabs, 4) { Name = "Warszawa", Distancetocenter = -2 },
                new District(AllCabs, 5) { Name = "Warszawa", Distancetocenter = -2 },
            };
        }

        public bool controll()
        {
            view.loadView();
            // 
            return false;
        }


    }
}

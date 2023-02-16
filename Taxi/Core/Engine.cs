using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string[] sendCab()
        {
            int cabId = 0;
            var district = AllDistrict.Where(x => x.Id == view.pos + 1).First();
            if (district.Cabs.Where(x => x.Status == false).ToList().Count > 0) {
                cabId = district.Cabs.Where(x => x.Status == false).ToList()[0].Id;
            } else if (district.Cabs.Where(x => x.Status == false).ToList().Count == 0 && AllCabs.Where(x => x.Status == false).ToList().Count > 0) {
                var cabs = AllCabs.Where(x => x.Status == false).ToList();
                int road = 100;
                int id = 0;
                foreach(var cabFree in cabs) {
                    int tmp = Math.Abs(AllDistrict.Where(x => x.Id == cabFree.DistrictId).ToList()[0].Distancetocenter) + Math.Abs(AllDistrict.Where(x => x.Id == view.pos+1).ToList()[0].Distancetocenter);
                    if (tmp < road) { 
                        road = tmp;
                        id = cabFree.Id;
                    }
                }
                cabId = id;
            } else {
                int road = 100;
                int id = 0;
                foreach (var cabFree in AllCabs) {
                    int tmp = Math.Abs(AllDistrict.Where(x => x.Id == cabFree.DistrictId).ToList()[0].Distancetocenter) + Math.Abs(AllDistrict.Where(x => x.Id == view.pos + 1).ToList()[0].Distancetocenter);
                    if (tmp < road) {
                        road = tmp;
                        id = cabFree.Id;
                    }
                }
                cabId = id;
            }
            var cab = AllCabs.Where(x => x.Id == cabId).ToList()[0];
            AllDistrict.Where(x => x.Id == cab.DistrictId).ToList()[0].Cabs.Remove(cab);
            cab.Status = true;
            district.Cabs.Add(cab);
            cab.DistrictId = district.Id;

            string time = Convert.ToString(calcTime(cab.Id, AllDistrict.Where(x => x.Id == view.pos+1).First().Id));
            string[] response = { cab.Name, time };
            return response;
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
            Console.Clear();
            loadView();

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Enter:
                    confirm();
                    break;
                case ConsoleKey.UpArrow:
                    view.pos = view.pos - 1;
                    break;
                case ConsoleKey.DownArrow:
                    view.pos = view.pos + 1;
                    break;
                case ConsoleKey.Escape:
                    if (view.viewName == "menu") { return true; } else { view.viewName = "menu"; }
                    break;
            }

            return false;
        }

        public void loadView()
        {
            Console.ForegroundColor = ConsoleColor.White;
            switch (view.viewName)
            {
                case "menu":
                    view.menu();
                    break;
                case "districtList":
                    view.districtList(AllDistrict);
                    break;
                case "cabList":
                    view.cabList(AllCabs);
                    break;
                default:
                    break;
            }
        }

        void confirm()
        {
            switch (view.viewName)
            {
                case "menu":
                    if (view.pos == 0) { view.viewName = "cabList"; }
                    if (view.pos == 1) { view.viewName = "districtList"; }
                    if (view.pos == 2) { view.viewName = "districtList"; }
                    view.pos = 0;
                    break;
                case "districtList":
                    string[] data = sendCab();
                    view.pos = 0;
                    view.summary(data);
                    break;
            }
        }

        int calcTime(int cabId, int distId)
        {
            int time = 0;
            return time;
        }
    }
}

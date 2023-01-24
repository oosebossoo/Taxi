using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cab> CabList = new List<Cab>() {
                new Cab() { Id = 0, Name = "Opel", DistrictId = 0, Status = false},
                new Cab() { Id = 1, Name = "Ferrari", DistrictId = 0, Status = false},
                new Cab() { Id = 2, Name = "Ferrari", DistrictId = 0, Status = false},
                new Cab() { Id = 3, Name = "Ferrari", DistrictId = 0, Status = false},
                new Cab() { Id = 4, Name = "Ferrari", DistrictId = 0, Status = false}
            };

            List<District> DistrictList = new List<District>() {
                new District() { Id = 1, Name = "Łódź", Distancetocenter = -2},
                new District() { Id = 2, Name = "Warszawa", Distancetocenter = -2 },
                new District() { Id = 3, Name = "Warszawa", Distancetocenter = -2 },
                new District() { Id = 4, Name = "Warszawa", Distancetocenter = -2 },
            };

            foreach (var cab in CabList)
            {
                Console.WriteLine(cab.Name);
            }

            Console.WriteLine("-----------------");

            foreach (var district in DistrictList)
            {
                Console.WriteLine(district.Name);
            }
            Console.ReadKey();
        }
    }
}
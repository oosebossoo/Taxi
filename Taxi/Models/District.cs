using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Distancetocenter { get; set; }
        public List<Cab> Cabs { get; set; }

        public District(List<Cab> AllCabs, int Id)
        {
            this.Id = Id;
            Cabs = AllCabs.Where(x => x.DistrictId == this.Id).Where(x => x.Status == false).ToList();
        }
    }
}

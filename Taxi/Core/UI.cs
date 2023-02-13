using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class UI
    {
        public string viewName { get; set; }

        public UI()
        {
            this.viewName = "start";
        }

        public void loadView(List<District> districts = null)
        {
            switch (viewName)
            {
                case "start":
                    welcome();
                    break;
                case "districtList":
                    districtList(districts);
                    break;
                default:
                    blank();
                    break;
            }
        }
        public void welcome()
        {
            Console.Clear();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|             Witaj            |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Zamów taxi");
            // this.viewName = "districtList";
        }

        public void districtList(List<District> districts)
        {
            foreach(var district in districts) {
                Console.WriteLine(district.Name);
            }
            Console.WriteLine("Wybierz id dzielnicy");

            this.viewName = "start";
        }

        public void taxiList()
        {
            Console.Clear();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|             Witaj            |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Zamów taxi");
            // foreach() {
            //
            //}
        }

        public void blank()
        {
            Console.Clear();
        }

    }
}

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
            Engine Engine = new Engine();
            Engine.loadAllCabs();
            Engine.loadAllDistricts();

            while (true)
            {
                if (Engine.controll()) break;
                Console.ReadKey();
            }

            //foreach (var cab in engine.AllCabs)
            //{
            //    Console.WriteLine(cab.Name);
            //}

            //Console.WriteLine("-----------------");

            //foreach (var district in engine.AllDistrict)
            //{
            //    Console.WriteLine(district.Name);
            //}

            Console.ReadKey();
        }
    }
}
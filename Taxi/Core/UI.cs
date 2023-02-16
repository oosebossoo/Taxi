using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class UI
    {
        public int pos { get; set; }
        public string viewName { get; set; }

        public UI()
        {
            this.viewName = "menu";
            this.pos = 0;
        }

        public void setView(int pos)
        {

        }

        public void menu() 
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("|     Witaj w aplikacji do zamawiania taksówek!   |");
            Console.WriteLine("+-------------------------------------------------+");
            string[] list = { "LISTA WSZYSTKICH TAKSÓWEK", "LISTA WSZYSTKICH DZIELNIC", "ZAMÓW TAKSÓWKĘ" };
            for (int key = 0; key < list.Count(); key++)
            {
                if (key == pos)
                {
                    Console.Write("[*] ");
                }
                else
                {
                    Console.Write("[ ] ");
                }
                Console.WriteLine($"{list[key]}");
            }
            Console.WriteLine();
            Console.WriteLine("Kliknij enter jeśli chcesz przejść dalej...");
            Console.WriteLine("Kliknij escape jeśli chcesz zamknąć program...");
            
        }

        public void districtList(List<District> districts)
        {
            Console.WriteLine("Lista dzielnic");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("   | NAZWA | ILOŚĆ DOSTĘPNYCH TAKSÓWEK |");
            for (int key = 0; key < districts.Count; key++) {
                if (key == pos) {
                    Console.Write("[*] ");
                } else {
                    Console.Write("[ ] ");
                }
                Console.Write($"{districts[key].Name} | liczba taxi: ");
                if (districts[key].Cabs.Count < 1) {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (districts[key].Cabs.Count > 1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{districts[key].Cabs.Count}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void cabList(List<Cab> cabs)
        {
            Console.Clear();
            Console.WriteLine("Lista taksówek");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine(" | ID |   SAMOCHÓD   | STATUS | AKTUALNA DZIELNICA |");

            foreach ( var cab in cabs) {
                if (cab.Status) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" - {cab.Id} | {cab.Name} | Zajęta");
                } else {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" - {cab.Id} | {cab.Name} | Wolna");
                }
            }
        }

        public void summary(string[] data)
        {
            Console.WriteLine($"Zamówiono: {data[0]}, szacowany czas oczekiwania to: {data[1]} minut");
            Console.ReadKey();
        }

        public void order(List<District> districts)
        {
            Console.WriteLine("Dokąd chcesz zamówić taksówke?");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("   | NAZWA | ILOŚĆ DOSTĘPNYCH TAKSÓWEK |");
            for (int key = 0; key < districts.Count; key++)
            {
                if (key == pos)
                {
                    Console.Write("[*] ");
                }
                else
                {
                    Console.Write("[ ] ");
                }
                Console.Write($"{districts[key].Name} | liczba taxi: ");
                if (districts[key].Cabs.Count < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (districts[key].Cabs.Count > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{districts[key].Cabs.Count}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

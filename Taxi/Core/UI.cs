﻿using System;
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
            this.viewName = "start";
            this.pos = 0;
        }

        public void setView(int pos)
        {

        }

        public void welcome()
        {
            Console.Clear();
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("|     Witaj w aplikacji do zamawiania taksówek!   |");
            Console.WriteLine("+-------------------------------------------------+");
            this.viewName = "menu";
        }

        public void menu() 
        {
            Console.Clear();
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

            Console.WriteLine("Kliknij escape jeśli chcesz zamknąć program");
        }

        public void districtList(List<District> districts)
        {
            Console.WriteLine("Dokąd chcesz zamówić taksówke?");
            Console.WriteLine("");
            for (int key = 0; key < districts.Count; key++) {
                if (key == pos) {
                    Console.Write("[*] ");
                } else {
                    Console.Write("[ ] ");
                }
                Console.Write($"{districts[key].Name}, liczba taxi: ");
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
            Console.WriteLine("");

            foreach ( var cab in cabs) {
                if (cab.Status) {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($" - {cab.Id} {cab.Name} {cab.Status}");
            }
        }

        public void summary(string[] data)
        {
            Console.WriteLine($"Zamówiono: {data[0]}, szacowany czas oczekiwania to: {data[1]}");
            Console.ReadKey();
        }
    }
}

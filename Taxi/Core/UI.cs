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

        public void loadView()
        {
            switch (viewName)
            {
                case "start":
                    welcome();
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
        }

        public void blank()
        {
            Console.Clear();
        }

    }
}

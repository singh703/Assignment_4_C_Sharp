using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class car
    {
        public string make;
        public string model;
        public int year;

        public car(String make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public string Data
        {
            get
            {
                return $"Car Details is {make}, {model}, {year}";

            }



        }
        public static void Main(String[] args)
        {
            car c1 = new car("Tata", "Nexa", 2005);
            Console.WriteLine(c1.Data);
        }

    }


}
    

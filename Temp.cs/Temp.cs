using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Temp
    {
        public int t;

        public int Tem
        {
            set
            {
                this.t = value;

            }
            get
            {
                return (t * 9 / 5) + 32;
            }

        }


        public static void main(string[] args)
        {
            Temp s = new Temp();
            s.Tem = 37;
            Console.WriteLine(s.Tem);
        }



    }
}

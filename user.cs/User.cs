using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class User
    {
        public string f_name;
        public string l_name;


        public string Data
        {
            set
            {
                f_name = value;
                l_name = value;
            }
            get
            {
                return $"{f_name} {l_name}";


            }

        }

        public static void main(string[] args)
        {
            User u1 = new User();
            u1.f_name = "AP";
            u1.l_name = "Singh";
            Console.WriteLine(u1.Data);

        }






    }
}
    
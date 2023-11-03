using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Season_enum
    {
        public enum Season
        {
            winter = 1, summer, rain, fall
        }

        public static void main(string[] args)
        {
            Console.WriteLine(" enter season");
            int s = Convert.ToInt32(Console.ReadLine());

            switch (s)
            {
                case 1:
                    {
                        Console.WriteLine($"Current season is {Season.winter}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Current season is {Season.summer}");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine($"Current season is {Season.rain}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Current season is {Season.fall}");
                        break;
                    }

            }
        }
    }
}

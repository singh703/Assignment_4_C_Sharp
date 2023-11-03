using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Shape_Area
    {
        public enum shape
        {
            Circle = 1, Square, Triangle
        }
        public static void main(string[] args)
        {
            Console.WriteLine(" Choose name of the shape(Circle,Square,Triangle)");
            String s = Console.ReadLine();

            switch (s)
            {
                case "Circle":
                    {
                        Console.WriteLine("enter the radius of the circle ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        double area = 3.14 * a * a;
                        Console.WriteLine(area);
                        break;



                    }
                case "Square":
                    {
                        Console.WriteLine("enter the side of square ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        float area = a * a;
                        Console.WriteLine(area); break;



                    }

                case "Triangle":
                    {
                        Console.WriteLine("enter the length ");
                        int l = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the height ");
                        int h = Convert.ToInt32(Console.ReadLine());
                        double area = (l * h) / 2;
                        Console.WriteLine(area); break;



                    }
                default:
                    {
                        Console.WriteLine("invalid Choice");
                        break;
                    }
            }
        }
    }
}
    

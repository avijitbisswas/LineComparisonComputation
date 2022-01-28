using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class CheckEquality
    {
        public void Equality()
        {
            Console.WriteLine("(x1,y1) & (x2,y2) are 1st line coordinates");
            Console.WriteLine("(x3,y3) & (x4,y4) are the 2nd line cordinates");
            Console.WriteLine("Enter (x1,y1) co-ordinates: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter (x2,y2) coordinates: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

                        
            Console.WriteLine("Enter (x3,y3) coordinates: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter (x4,y4) coordinates: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            double Line1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double Line2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            if (Line1 == Line2)
            {
                Console.WriteLine("Line1 and Line2 are equal");
            }
            else
            {
                Console.WriteLine("Line1 and Line2 are not equal");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Comptation Program");
            Console.WriteLine("select the task ");
            Console.WriteLine("1.Length of the line");
            Console.WriteLine("2.Compare equality of two lines");
            Console.WriteLine("3.Line Comparision");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Line length");
                    LineLength linelength = new LineLength();
                    linelength.ComputeLines();
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Check Equality of Two Lines");
                    CheckEquality checkEquality = new CheckEquality();
                    checkEquality.Equality();
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Comparision of two lines");
                    LineComparision lineComparision = new LineComparision();
                    lineComparision.EndComparision();
                    Console.ReadLine();
                    break;


            }




        }






    }
}










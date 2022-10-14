using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class CompareToMethod
    {
        public void CompareLinesWithCompareTo()
        {
            Console.WriteLine("Enter the value of x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y4:");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double Length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("The Length of Line is: " + Length1);
            Console.WriteLine("The Length of Line is: " + Length2);

            int Status = Length1.CompareTo(Length2);
            if (Status > 0)
            {
                Console.WriteLine("Line1 is greater than Line2");

            }
            else if (Status < 0)
            {
                Console.WriteLine("Line1 is Less than Line2");
            }
            else
            {
                Console.WriteLine("Line1 is equal to Line2");
            }


        }
    }
}

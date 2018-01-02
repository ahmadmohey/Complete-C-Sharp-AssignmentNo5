using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(1,13);
            string monthName = "";
                        
            if (x == 1)
                monthName = "January - 31 days";
            else if (x == 2 )
                monthName = "February - 28/29 days";
            else if (x == 3)
                monthName = "March - 31 days";
            else if (x == 4)
                monthName = "April - 30 days";
            else if (x == 5)
                monthName = "May - 31 days";
            else if (x == 6)
                monthName = "June - 30 days";
            else if (x == 7)
                monthName = "July - 31 days";
            else if (x == 8)
                monthName = "August - 31 days";
            else if (x == 9)
                monthName = "September - 30 days";
            else if (x == 10)
                monthName = "October - 31 days";
            else if (x == 11)
                monthName = "November - 30 days";
            else 
                monthName = "December - 31 days";

            Console.WriteLine(monthName);
        }
    }
}

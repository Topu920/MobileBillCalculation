using System;

namespace MobileBillCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime peackHourStart = new DateTime(2019, 08, 31, 09, 00, 00);
            DateTime peackHourEnd = new DateTime(2019, 08, 31, 22, 59, 59);

            DateTime starttime;
            DateTime endtime;
            Console.WriteLine("Start Time: ");
            starttime = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("\nEnd Time: ");
            endtime = DateTime.Parse(Console.ReadLine());
            TimeSpan timeDifference = endtime.Subtract(starttime);
            double TotalCallTime = timeDifference.TotalSeconds / 20;
            decimal mobileBill = 0;
            for (int i = 0; i < Math.Ceiling(TotalCallTime); i++)
            {
                DateTime starttime1 = starttime.AddSeconds(20);
                if (starttime1 >= peackHourStart && starttime1 <= peackHourEnd)
                {
                    mobileBill += 30;
                }
                else
                {
                    mobileBill += 20;
                }
                starttime = starttime1; 
            }
            Console.WriteLine("\nTotal Bill: " + mobileBill/100 + " Taka");
            Console.ReadKey();

        }
    }
}

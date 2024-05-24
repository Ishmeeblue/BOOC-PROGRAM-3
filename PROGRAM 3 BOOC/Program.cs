using System;

namespace PROGRAM_3_BOOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ResCon = true;
            Console.WriteLine("Welcome to My Converter<3");
            while (ResCon)
            {
                Console.WriteLine("What Kind of Convertion Do You Need?");
                Console.WriteLine("SM = Seconds to Minutes, MH = Minutes to Hours, HD = Hours to Days, DM = Days to Months");
                string conversion = Console.ReadLine();
                if (conversion.ToUpper() == "SM")
                {
                    Console.Write("Put the Seconds:");
                    int sec = int.Parse(Console.ReadLine());
                    int min = sec / 60;
                    Console.WriteLine($"Seconds to Minutes : " + min + " Minutes");
                }
                else if (conversion.ToUpper() == "MH")
                {
                    Console.Write("Put the Minutes:");
                    int MIN = int.Parse(Console.ReadLine());
                    int hour = MIN / 60;
                    Console.WriteLine($"Minutes to Hours : " + hour + " Hours");
                }
                else if (conversion.ToUpper() == "HD")
                {
                    Console.Write("Put the Hours:");
                    int HOUR = int.Parse(Console.ReadLine());
                    int Day = HOUR / 24;
                    Console.WriteLine($"Hours to Days : " + Day + " Days");
                }
                else if (conversion.ToUpper() == "DM")
                {
                    Console.Write("Put the Days:");
                    int DAY = int.Parse(Console.ReadLine());
                    int Mon = DAY / 30;
                    Console.WriteLine($"Days to Months : " + Mon + " Days");
                }
                else
                {
                    Console.WriteLine("PLEASE READ THE CHOICES CAREFULLY!");break;
                }
                Console.WriteLine("Need to Convert Again? Press C to Continue or Any Buttons to Exit :");
                string Res = Console.ReadLine().Trim().ToUpper();
                ResCon = (Res == "C");
            }
            Console.WriteLine("Okie Babye! Thank You For Using My Converter<3");
        }
    }
}

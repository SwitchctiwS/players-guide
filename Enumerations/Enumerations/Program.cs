using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    // Enums are defined directly in the namespace or in their own file
    public enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    // The default underlying type of an enum is int (but it is possible to choose other integral types).
    // That means that Sunday has a value of 0, Monday has a value of 1, and so on.
    // You can technically cast an enum type, but you can also explicitly cast to a value that may not be correct. So be cautious.
    // Examples in Main

    public enum MonthsOfTheYear { December = 12, November = 11, October = 10, Septemeber = 9, August = 8, July = 7,
        June = 6, May = 5, April = 4, March = 3, Feburary = 2, January = 1, Error = 0 };   // You can also assign numbers to enum values

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek tomorrow;    // Declare a variable
            tomorrow = DaysOfWeek.Tuesday;  // Assign value with dot operator (".");

            int dayAsInt = (int)DaysOfWeek.Sunday;
            DaysOfWeek today = (DaysOfWeek)dayAsInt; // Both of these require an explicit cast.

            DaysOfWeek dayAfterTomorrow = (DaysOfWeek)17; // Legal, but a bad idea...


            // Months of the Year
            int choice; // What the user enters
            MonthsOfTheYear month = MonthsOfTheYear.Error; // int choice gets transfered to this
            bool exit = false; // Exit flag for when user enters a valid choice

            do
            {
                // Get user input
                Console.WriteLine("Please enter a number from 1 to 12 (inclusive).");
                choice = Convert.ToInt32(Console.ReadLine());

                // Convert to MonthsOfTheYear if valid
                if (choice >= 1 && choice <= 12)
                {
                    month = (MonthsOfTheYear)choice;
                    exit = true;
                }
                else
                    Console.WriteLine("Sorry, that was an incorrect number.\n"); // Repeat if invalid

            } while (exit == false);

            // Outputs user's choice (long way)
            /*
            switch (month)
            {
                case MonthsOfTheYear.January:
                    Console.WriteLine("January");
                    break;
                case MonthsOfTheYear.Feburary:
                    Console.WriteLine("Feburary");
                    break;
                case MonthsOfTheYear.March:
                    Console.WriteLine("March");
                    break;
                case MonthsOfTheYear.April:
                    Console.WriteLine("April");
                    break;
                case MonthsOfTheYear.May:
                    Console.WriteLine("May");
                    break;
                case MonthsOfTheYear.June:
                    Console.WriteLine("June");
                    break;
                case MonthsOfTheYear.July:
                    Console.WriteLine("July");
                    break;
                case MonthsOfTheYear.August:
                    Console.WriteLine("August");
                    break;
                case MonthsOfTheYear.Septemeber:
                    Console.WriteLine("September");
                    break;
                case MonthsOfTheYear.October:
                    Console.WriteLine("October");
                    break;
                case MonthsOfTheYear.November:
                    Console.WriteLine("November");
                    break;
                case MonthsOfTheYear.December:
                    Console.WriteLine("Decemeber");
                    break;
                default:
                    Console.WriteLine("That was not a vaild choice."); // Fail condition (MonthsOfTheYear.Error)
                    break;
            }
            */

            // Outputs user's choice (easy/best way)
            Console.WriteLine(month);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

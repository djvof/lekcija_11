using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int userNumber = GetNumber();
                Console.WriteLine($"User entered: {userNumber}");
            }
            catch (NumberLargerThanTenException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("End of program");
        }

        private static int GetNumber()
        {
            Console.WriteLine("Ievadi skaitli");

            string userNumberInput = Console.ReadLine();
            int userNumber;

            try
            {
                userNumber = int.Parse(userNumberInput);

                if (userNumber > 10)
                {
                    throw new NumberLargerThanTenException("Aplikācija atbalsta skaitļus tikai līdz 10.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Hey tas nebija skaitlis: {userNumberInput}");
                userNumber = GetNumber();
            }

            return userNumber;
        }



    }
}





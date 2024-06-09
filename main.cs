using System;

namespace Hurricane{
    
}

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the wind speed (mph): ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            string category = GetHurricaneCategory(windSpeed);

            if (category == "Not a hurricane")
            {
                Console.WriteLine($"Not a Hurricane.");
            }
            else
            {
                Console.WriteLine($"The wind speed {windSpeed} mph is a {category} hurricane.");
            }

            Console.ReadKey();
        }

        static string GetHurricaneCategory(double windSpeed)
        {
            if (windSpeed < 74)
            {
                return "Not a hurricane";
            }
            else if (windSpeed >= 74 && windSpeed <= 96)
            {
                return "Category One";
            }
            else if (windSpeed > 96 && windSpeed <= 111)
            {
                return "Category Two";
            }
            else if (windSpeed > 111 && windSpeed <= 130)
            {
                return "Category Three";
            }
            else if (windSpeed > 130 && windSpeed <= 157)
            {
                return "Category Four";
            }
            else
            {
                return "Category Five";
            }
        }
    }



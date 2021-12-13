using System;
using System.Collections.Generic;

namespace List_training
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            int counter = 0;

            Console.WriteLine("Hello user!\n");
            Console.WriteLine("Which country's capital do you want to know?\n");

            Dictionary<string, string> capitals = new Dictionary<string, string>();
            {
                capitals.Add("Ukraine", "Kiev");
                capitals.Add("Russia", "Moscow");
                capitals.Add("Belarus", "Minsk");
                capitals.Add("Poland", "Warsawa");
                capitals.Add("Czech Rp", "Praga");
                capitals.Add("Germany", "Berlin");
                capitals.Add("France", "Paris");
                capitals.Add("Norway", "Oslo\n");
            };

            foreach (KeyValuePair<string, string> keyValue in capitals)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            string country = Console.ReadLine();

            foreach (string keys in capitals.Keys)
            {
                if (country == keys)
                {
                    Console.WriteLine(CapitalInfo(country));
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("We don't have that capital, piece of shit!");
            }
        }
        public static string CapitalInfo(string country)
        {
            switch (country)
            {
                case "Ukraine":
                    return "Киев";
                case "Russia":
                    return "Москва";
                case "Belarus":
                    return "Минск";
                case "Poland":
                    return "Варшава";
                case "Czech Rp":
                    return "Прага";
                case "Germany":
                    return "Берлин";
                case "France":
                    return "Париж";
                case "Norway":
                    return "Осло";

                default: return "Chech orfography";
            }
        }
    }
}
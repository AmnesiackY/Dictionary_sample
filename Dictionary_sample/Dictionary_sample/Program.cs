using System;
using System.Collections.Generic;

namespace List_training
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    return "It is located in northern Ukraine. In 2010, Kiev was the seventh most populous city in Europe after Istanbul, Moscow, London, St. Petersburg, Berlin, and Madrid.";
                case "Russia":
                    return "Moscow is the sports center of the country. In 1980 Moscow hosted the XXII Summer Olympic Games, and in 2018 the city was one of the hosts of the FIFA World Cup.";
                case "Belarus":
                    return "Minsk was first mentioned in the chronicles almost a hundred years earlier than Moscow: the record was made in 1067.";
                case "Poland":
                    return "Nowhere in Poland, except Warsaw, can you find the subway.";
                case "Czech Rp":
                    return "The capital of the Czech Republic is about 1150 years old. More precisely, it was founded in 880 A.D.";
                case "Germany":
                    return "The Berlin Zoo is ranked first in the world in terms of the number of animals. It contains 1,380 different animal species and over 18,662 animals.";
                case "France":
                    return "Paris was one of the first cities in the world to install street lights.";
                case "Norway":
                    return "Mohammed is the most popular name for a boy in Oslo.";

                default: return "Chech orfography";
            }
        }
    }
}
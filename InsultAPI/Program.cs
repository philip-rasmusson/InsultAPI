using System;

namespace InsultAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var adjectiveList = Generator.GenerateList("adjective");
            var amountList = Generator.GenerateList("amount");
            var animalList = Generator.GenerateList("animal");
            var animalPartsList = Generator.GenerateList("animal_parts");


            var rand = new Random();

            Console.WriteLine($"You {adjectiveList[rand.Next(0, adjectiveList.Count -1)]} {amountList[rand.Next(0, amountList.Count - 1)]} of {animalList[rand.Next(0, animalList.Count - 1)]} {animalPartsList[rand.Next(0, animalPartsList.Count - 1)]}");

        }
    }
}


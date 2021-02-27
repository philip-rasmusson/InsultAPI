using System;
using System.Collections.Generic;
using System.Text;

namespace InsultAPI
{
    class StaticData
    {
        StaticData()
        {
            var adjectiveList = GenerateList("adjective");
            var amountList = GenerateList("amount");
            var animalList = GenerateList("animal");
            var animalPartsList = GenerateList("anmial-parts");
        }

        private static List<string> GenerateList(string filename)
        {
            var list = new List<string>();



            return list;
        }
    }


}

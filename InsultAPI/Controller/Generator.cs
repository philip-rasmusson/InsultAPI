using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InsultAPI
{
    public class Generator
    {
        public static List<string> GenerateList(string filename)
        {
            var list = new List<string>();
            var file = File.ReadLines(@"..\..\..\Database\Words\" + filename + ".txt");

            foreach (var item in file)
            {
                list.Add(item);
            }
            return list;
        }
    }
}

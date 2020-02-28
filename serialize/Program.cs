using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace serialize
{
    class Program
    {
        static void Main(string[] args)
        {




            Human human = new Human();
            var json = JsonConvert.SerializeObject(human);

            var values = JsonConvert.DeserializeObject<Dictionary<string, Object>>(json);
            var name = values["Name"].ToString();
            var surname = values["Surname"].ToString();
            var hobbies = values["Hobbies"].GetType();
            var hobbies1 = values["Hobbies"]?.ToString();
            var hobbies2 = values["Hobbies"]?.ToString().Split(",");
            
            List<string> datalar = new List<string>();

            if (hobbies1.Contains(",")) {
                List<string> sad = hobbies2.ToList();
                foreach (var item in sad)
                {
                  
                    datalar.Add(item);
                }
            }
            foreach (var item in datalar)
            {
                Console.WriteLine(item);
            }
      
            Console.ReadLine();
        }
    }
    public class Human
    {
        public string Name { get; set; } = "Anar";
        public string Surname { get; set; } = "Leman";
        public string[] Hobbies { get; set; } = new[] { "leman","aaa","bbb" };
    }
    public class CastMe
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Hobbies { get; set; }
    }
}

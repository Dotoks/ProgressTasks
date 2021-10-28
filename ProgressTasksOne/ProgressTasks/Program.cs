using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ProgressTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("John", "Kennedy", 13);
            var person2 = new Person("Bob", "Green", 20);
            var person3 = new Person("Marly", "Green", 20);

            List<Person> listOfPersons = new List<Person>();

            listOfPersons.Add(person1);
            listOfPersons.Add(person2);
            listOfPersons.Add(person3);

            Console.WriteLine(ConvertToJson(listOfPersons));

        }

        private static string ConvertToJson(List<Person> listOfPersons)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var person in listOfPersons)
            {
                sb.AppendLine(JsonConvert.SerializeObject(person));
            }
            return sb.ToString();
        }
    }
}

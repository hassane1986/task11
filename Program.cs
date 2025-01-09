using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{

    class Program
    {
        static void Main(string[] args)
        {
           
            Personi[] persons = new Personi[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter age of person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());
                persons[i] = new Personi(name, age);
            }

           // Search
            Personi oldest = persons[0];
            foreach (var person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"\nThe oldest person is {oldest.Name} with age {oldest.Age}.");
        }
    }
}

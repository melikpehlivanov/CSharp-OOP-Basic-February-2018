namespace _04.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            
            var people = new List<Person>();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                var person = new Person(name, age);
                people.Add(person);
            }

            people
                .Where(p=> p.Age > 30)
                .OrderBy(p=> p.Name)
                .ToList()
                .ForEach(p=> Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}

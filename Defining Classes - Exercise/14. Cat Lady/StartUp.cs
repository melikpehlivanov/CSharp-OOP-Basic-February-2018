namespace _14.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var cats = new List<Cat>();

            while (input != "End")
            {
                var catInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var breed = catInfo[0];
                var name = catInfo[1];
                var breedSpecificInfo = catInfo[2];

                Cat cat = new Cat(breed, name);
                switch (breed)
                {
                    case "Siamese":
                        cat = new Siamese(breed, name, int.Parse(breedSpecificInfo));
                        break;
                    case "Cymric":
                        cat = new Cymric(breed, name, double.Parse(breedSpecificInfo));
                        break;
                    case "StreetExtraordinaire":
                        cat = new extraordinary(breed, name, int.Parse(breedSpecificInfo));
                        break;
                }
                cats.Add(cat);
            }

            var searchedName = Console.ReadLine();

            var finalCat = cats.FirstOrDefault(c => c.Name == searchedName);
            if (finalCat != null)
            {
                Console.WriteLine(finalCat.ToString());
            }
        }
    }
}

﻿namespace _05.Pizza_Calories
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (tokens[0])
                    {
                        case "Dough":
                            var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetCalories():f2}");
                            break;
                        case "Topping":
                            var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetCalories():f2}");
                            break;
                        case "Pizza":
                            MakePizza(tokens);
                            break;
                    }

                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        public static void MakePizza(string[] tokens)
        {
            var numberToppings = int.Parse(tokens[2]);
            var pizza = new Pizza(tokens[1], numberToppings);

            var doughInfo = Console.ReadLine().Split(' ');
            var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
            pizza.Dough = dough;

            for (var i = 0; i < numberToppings; i++)
            {
                var topInfo = Console.ReadLine().Split(' ');
                var topping = new Topping(topInfo[1], double.Parse(topInfo[2]));
                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
        }
    }
}


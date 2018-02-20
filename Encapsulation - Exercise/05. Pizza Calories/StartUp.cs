using System;

public class StartUp
{
    public static void Main()
    {
        var pizzaName = Console.ReadLine().Split();

        try
        {
            MakePizza(pizzaName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void MakePizza(string[] tokens)
    {
        int numberOfToppings = 0;
        var pizza = new Pizza(tokens[1]);

        tokens = Console.ReadLine().Split();

        while (tokens[0] != "END")
        {

            if (tokens[0] == "Dough")
            {
                var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                pizza.Dough = dough;
            }
            else
            {
                var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                pizza.AddTopping(topping);
                numberOfToppings++;
            }

            tokens = Console.ReadLine().Split();
        }
        pizza.NumberOfToppings = numberOfToppings;

        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
    }
}




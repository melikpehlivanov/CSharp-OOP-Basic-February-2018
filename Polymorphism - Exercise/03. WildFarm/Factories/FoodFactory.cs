﻿public class FoodFactory
{
    public static Food GetFood(string[] tokens)
    {
        if (tokens.Length < 2) return null;

        var foodType = tokens[0];
        var foodQuantity = int.Parse(tokens[1]);

        switch (foodType)
        {
            case "Vegetable": return new Vegetable(foodQuantity);
            case "Meat": return new Meat(foodQuantity);
            default: return null;
        }
    }
}
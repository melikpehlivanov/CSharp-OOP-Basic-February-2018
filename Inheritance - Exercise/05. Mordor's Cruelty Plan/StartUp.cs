namespace _05.Mordor_s_Cruelty_Plan
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var foods = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var gandalf = new Gandalf();
            foreach (var food in foods)
            {
                gandalf.EatFood(food);
            }

            Console.WriteLine(gandalf.HappinessPoints);
            Console.WriteLine(gandalf.CalculateMood());
        }
    }
}

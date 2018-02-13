namespace _05.Date_Modifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.CalculateDateDifference(firstDate, secondDate));
        }
    }
}

namespace _01.Class_Box
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var box = new Box(lenght, width, height);

            Console.WriteLine(box.ToString());
        }
    }
}

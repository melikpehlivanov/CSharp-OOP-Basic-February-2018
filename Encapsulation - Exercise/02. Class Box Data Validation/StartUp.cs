﻿namespace _02.Class_Box_Data_Validation
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                var box = new Box(lenght, width, height);

                Console.WriteLine(box.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

namespace _01._Define_a_Class_Person
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            //var pesho = new Person("Pesho", 20);
            //var gosho = new Person("Gosho", 18);
            //var stamat = new Person("Stamat", 43);
            //Console.WriteLine(stamat.name);
        }
    }
}

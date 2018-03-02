namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var webSites = Console.ReadLine().Split(' ');

            var smartphone = new Smartphone();
            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(phoneNumber));
            }
            foreach (var webSite in webSites)
            {
                Console.WriteLine(smartphone.Browse(webSite));
            }
        }
    }
}

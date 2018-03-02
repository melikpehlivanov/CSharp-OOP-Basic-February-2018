namespace _04.Telephony
{
    using System.Linq;

    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string webSite)
        {
            if (webSite.Any(ch => char.IsDigit(ch)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {webSite}!";
        }

        public string Call(string phoneNumber)
        {
            if (phoneNumber.Any(ch => !char.IsDigit(ch)))
            {
                return "Invalid number!";
            }
            return $"Calling... {phoneNumber}";
        }
    }
}

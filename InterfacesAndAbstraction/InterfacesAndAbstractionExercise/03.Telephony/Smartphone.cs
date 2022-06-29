using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : IPhone, ISmart
    {
        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";
        }

        public string CallPhone(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }
            return "Invalid number!";
        }
    }
}

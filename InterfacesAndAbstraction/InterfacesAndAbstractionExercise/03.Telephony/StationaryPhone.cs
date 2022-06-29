using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : IPhone
    {
        public string CallPhone(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Dialing... {number}";
            }
            return "Invalid number!";
        }
    }
}

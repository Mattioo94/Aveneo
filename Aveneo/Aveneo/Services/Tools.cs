using Aveneo.Services.IoC;
using System;
using System.Text.RegularExpressions;

namespace Aveneo.Services
{
    public class Tools : ITools
    {
        public string ShortNumber(string number)
        {
            var nip1 = new Regex(@"^([0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2})|([0-9]{3}-[0-9]{2}-[0-9]{2}-[0-9]{3})$");
            var nip2 = new Regex(@"^[A-Z]{2}[0-9]{10}$");

            switch (number)
            {
                case string s when nip1.Match(s).Success:
                    return String.Concat(number.Split('-', StringSplitOptions.None));
                case string s when nip2.Match(s).Success:
                    return number.Substring(2);
                default:
                    return number;
            }
        }
    }
}

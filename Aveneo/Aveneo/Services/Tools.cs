using Aveneo.Services.IoC;
using System;
using System.Text.RegularExpressions;

namespace Aveneo.Services
{
    public class Tools : ITools
    {
        public string ShortNumber(string number)
        {
            var nip1 = new Regex(@"^\d{3}-\d{3}-\d{2}-\d{2}$");
            var nip2 = new Regex(@"^\d{3}-\d{2}-\d{2}-\d{3}$");
            var nip3 = new Regex(@"^[A-Z]{2}\d{10}$");

            switch (number)
            {
                case string s when nip1.Match(s).Success || nip2.Match(s).Success:
                    return String.Concat(number.Split('-', StringSplitOptions.None));
                case string s when nip3.Match(s).Success:
                    return number.Substring(2);
                default:
                    return number;
            }
        }
    }
}

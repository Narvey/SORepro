using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORepro
{
    class Program
    {
        static void Main(string[] args)
        {
            var page = new { ClientQueryString = "thing" };

            if (page != null && TryGetURLParams(page.ClientQueryString, out string stringOne))
            {
                stringOne.ToString();
                return;
            }
        }

        static bool TryGetURLParams(string input, out string stringOne)
        {
            stringOne = input.ToLower();//do real things instead.
            return true;
        }
    }
}

using System;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int number)
        {
            string res = string.Empty;
            if (number % 3 == 0)
            {
                 res += "Foo";
            }
            if (number % 5 == 0)
            {
                 res += "Bar";
            }
            if (number % 7 == 0)
            {
                res += "Qix";
            }
            if(res == string.Empty){
                return number.ToString();
            }
            return res.ToString();
        }

    }
}
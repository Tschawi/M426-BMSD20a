using System;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int number)
        {
            if (number % 3 == 0)
            {
                return "Foo";
            }
            if (number % 5 == 0)
            {
                return "Bar";
            }
            return number.ToString();
        }

    }
}
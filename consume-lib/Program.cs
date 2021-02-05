using System;
using Foo;

namespace consume_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new SomeDerived
            {
                int_value = 10,
                str_value = "some string",                
            };
        }
    }
}

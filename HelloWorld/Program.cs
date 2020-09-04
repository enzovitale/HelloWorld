using System;

using Base;

using Derived;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            BaseGreeter g = new Greeter();
            Console.WriteLine(g.Greeting());

            IGreeter g_interface = new Greeter();
            Console.WriteLine(g_interface.Greeting());

            Greeter g_typed = new Greeter();
            Console.WriteLine(g_typed.Greeting());
        }
    }
}

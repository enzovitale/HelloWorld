using Base;

using Derived;


namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            BaseGreeter g = new Greeter();
            g.Greet();

            IGreeter g_interface = new Greeter();
            g_interface.Greet();

            var g_typed = new Greeter();
            g_typed.Greet();

            var g_Alternate_typed = new AlternateGreeter();
            g_Alternate_typed.Greet();
        }
    }
}

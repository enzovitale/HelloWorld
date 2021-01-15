using Base;

using Derived;


namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            BaseGreeter g_base = new Greeter();
            g_base.Greet();

            IGreeter g_interface = new Greeter();
            g_interface.Greet();

            var g_typed = new Greeter();
            g_typed.Greet();

            var g_typed_Alternate = new AlternateGreeter();
            g_typed_Alternate.Greet();
        }
    }
}

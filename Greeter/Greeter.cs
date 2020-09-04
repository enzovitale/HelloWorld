using Base;

namespace Derived
{
    /// <summary>
    /// This class greets the world in a very conventional way :-)
    /// </summary>
    public class Greeter : BaseGreeter
    {
        public override string Greeting() => "Hello, World!";
    }
}

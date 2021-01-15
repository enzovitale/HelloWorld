using Base;


namespace Derived
{
    public class AlternateGreeter : BaseGreeter
    {
        public override string Greeting() => "A different, but no less heartfelt, kind of Hello, World!";
    }
}

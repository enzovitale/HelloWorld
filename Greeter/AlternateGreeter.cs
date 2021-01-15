using Base;


namespace Derived
{
    /// <summary>
    /// This class greets the world in a bit of an alternate way ;-)
    /// </summary>
    public class AlternateGreeter : BaseGreeter
    {
        public override string Greeting(string? RecipientName = null) => $"A different, but no less heartfelt, kind of Hello, {RecipientName ?? "World"}!";
    }
}

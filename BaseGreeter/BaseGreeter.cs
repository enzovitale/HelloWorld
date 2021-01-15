namespace Base
{
    public abstract class BaseGreeter : IGreeter
    {
        public abstract string Greeting(string? RecipientName = null);
    }
}

using System;


namespace Base
{
    /// <summary>
    /// Base interface for greeter classes.
    /// Implementing classes are free to greet the world however they like. No swear words, though, OK? ;-)
    /// </summary>
    public interface IGreeter
    {
        string Greeting();
    }


    public static class IGreeterExtensions 
    {
        public static void Greet(this IGreeter g) => Console.WriteLine(g.Greeting());
    }
}

using NUnit.Framework;

using Derived;


namespace GreeterTest
{
    public class GreeterTests
    {
        [Test] public void GreeterTest()
        {
            var g = new Greeter();
            Assert.IsNotEmpty(g.Greeting());
        }

        [Test] public void GreeterTestPurposefullyFailing() => Assert.Fail();
    }
}
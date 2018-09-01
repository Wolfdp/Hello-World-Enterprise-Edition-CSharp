using System;

namespace Nya.HelloWorld
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            InstantiateHelloWorldMainClassAndRun();
        }

        public static void InstantiateHelloWorldMainClassAndRun() => new HelloWorld();

        public HelloWorld()
        {
            var factory = HelloWorldFactory.GetInstance();
            var helloWorld = factory.CreateHelloWorld();
            var helloWorldString = helloWorld.GetHelloWorld();
            var printStrategy = helloWorld.GetPrintStrategy();
            var code = helloWorld.Print(printStrategy, helloWorldString.GetHelloWorldString());
            if (code.Code != Status.Success)
                throw new Exception($"Failed to print: {code.Code}");
        }
    }
}

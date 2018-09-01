using System;

namespace Nya.HelloWorld
{
    public class StringFactory
    {
        private static readonly StringFactory instance = new StringFactory();

        public static StringFactory GetInstance() => instance;

        public HelloWorldModel CreateHelloWorldString(String text) => new HelloWorldModel(text);
    }
}

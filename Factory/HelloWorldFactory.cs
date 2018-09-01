namespace Nya.HelloWorld
{
    public class HelloWorldFactory
    {
        private static readonly HelloWorldFactory instance = new HelloWorldFactory();

        public static HelloWorldFactory GetInstance() => instance;

        public IHelloWorld CreateHelloWorld() => new HelloWorldImplementation();
    }
}

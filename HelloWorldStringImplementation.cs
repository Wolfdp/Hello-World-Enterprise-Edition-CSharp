namespace Nya.HelloWorld
{
    public class HelloWorldStringImplementation : IHelloWorldStringImplementation
    {
        public HelloWorldModel GetHelloWorldString() => StringFactory.GetInstance().CreateHelloWorldString("Hello, World!");
    }
}

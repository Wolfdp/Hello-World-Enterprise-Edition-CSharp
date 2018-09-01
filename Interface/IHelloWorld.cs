namespace Nya.HelloWorld
{
    public interface IHelloWorld
    {
        IHelloWorldStringImplementation GetHelloWorld();
        IPrintStrategy GetPrintStrategy();
        IStatusCode Print(IPrintStrategy strategy, HelloWorldModel toPrint);
    }
}

namespace Nya.HelloWorld
{
    public class HelloWorldImplementation : IHelloWorld
    {
        public IHelloWorldStringImplementation GetHelloWorld() => new HelloWorldStringImplementation();

        public IPrintStrategy GetPrintStrategy() => PrintStrategyFactory.GetInstance().CreateIPrintStrategy();

        public IStatusCode Print(IPrintStrategy strategy, HelloWorldModel toPrint) => strategy.Print(toPrint);
    }
}

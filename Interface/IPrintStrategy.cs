namespace Nya.HelloWorld
{
    public interface IPrintStrategy
    {
        IStatusCode SetupPrinting();
        IStatusCode Print(HelloWorldModel model);
    }
}

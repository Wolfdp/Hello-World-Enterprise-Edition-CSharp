using System;
using System.IO;

namespace Nya.HelloWorld
{
    public class PrintStrategyImplementation : IPrintStrategy
    {
        private TextWriter print;

        public IStatusCode SetupPrinting() => TryExecute(() => print = Console.Out);

        public IStatusCode Print(HelloWorldModel @string) => TryExecute(() => print.WriteLine(@string.Text));

        private StatusCodeImplementation TryExecute(Action action)
        {
            var status = Status.Success;
            try
            {
                action();
            }
            catch
            {
                status = Status.Error;
            }
            return new StatusCodeImplementation(status);
        }
    }
}

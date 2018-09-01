using System;

namespace Nya.HelloWorld
{
    public class PrintStrategyFactory
    {
        private static readonly PrintStrategyFactory instance = new PrintStrategyFactory();

        public static PrintStrategyFactory GetInstance() => instance;

        public IPrintStrategy CreateIPrintStrategy()
        {
            var printStrategy = new PrintStrategyImplementation();
            var code = printStrategy.SetupPrinting();
            if (code.Code != Status.Success)
                throw new Exception($"Failed to create IPrintStrategy: {code.Code}");
            return printStrategy;
        }
    }
}

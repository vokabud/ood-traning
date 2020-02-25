using System;
using StrategyAndReflection.Enums;
using StrategyAndReflection.Strategy;

namespace StrategyAndReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StrategyContext();

            context.SetStrategy(Param.ParamA);
            context.InvokeStrategy(); // Invoke ConcreteStrategyA

            context.SetStrategy(Param.ParamB);
            context.InvokeStrategy(); // Invoke ConcreteStrategyB

            context.SetStrategy(Param.ParamC);
            context.InvokeStrategy(); // Invoke ConcreteStrategyC
        }
    }
}

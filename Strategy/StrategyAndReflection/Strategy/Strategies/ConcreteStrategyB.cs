using System;
using StrategyAndReflection.Attributes;
using StrategyAndReflection.Enums;

namespace StrategyAndReflection.Strategy.Strategies
{
    [Param(Param.ParamB)]
    internal class ConcreteStrategyB : IStrategy
    {
        public void Invoke()
        {
            Console.WriteLine($"Invoke ConcreteStrategyB");
        }
    }
}

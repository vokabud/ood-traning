using System;
using StrategyAndReflection.Attributes;
using StrategyAndReflection.Enums;

namespace StrategyAndReflection.Strategy.Strategies
{
    [Param(Param.ParamA)]
    internal class ConcreteStrategyA : IStrategy
    {
        public void Invoke()
        {
            Console.WriteLine($"Invoke ConcreteStrategyA");
        }
    }
}

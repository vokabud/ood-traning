using System;
using StrategyAndReflection.Attributes;
using StrategyAndReflection.Enums;

namespace StrategyAndReflection.Strategy.Strategies
{
    [Param(Param.ParamC)]
    internal class ConcreteStrategyC : IStrategy
    {
        public void Invoke()
        {
            Console.WriteLine($"Invoke ConcreteStrategyC");
        }
    }
}

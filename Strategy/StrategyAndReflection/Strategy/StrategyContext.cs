using System;
using System.Linq;
using System.Reflection;
using StrategyAndReflection.Attributes;
using StrategyAndReflection.Enums;

namespace StrategyAndReflection.Strategy
{
    internal class StrategyContext
    {
        private IStrategy _currentStrategy;

        public void SetStrategy(Param param)
        {
            var strategies = Assembly.GetExecutingAssembly().GetTypes()
                .Where(p => typeof(IStrategy).IsAssignableFrom(p))
                .ToList();

            var strategyType = strategies
                .Single(t =>
                    this.IsTypeHasParamAttribute(t, param));

            this._currentStrategy = (IStrategy)Activator.CreateInstance(strategyType);
        }

        public void InvokeStrategy()
        {
            this._currentStrategy.Invoke();
        }

        private bool IsTypeHasParamAttribute(Type type, Param param)
        {
            return type.GetCustomAttributes(typeof(ParamAttribute), false)
                .Any(b => ((ParamAttribute)b).InputFormat == param);
        }
    }
}

using StrategyAndReflection.Enums;
using System;

namespace StrategyAndReflection.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class ParamAttribute : Attribute
    {
        public ParamAttribute(Param inputFormat)
        {
            this.InputFormat = inputFormat;
        }

        public Param InputFormat { get; }
    }
}

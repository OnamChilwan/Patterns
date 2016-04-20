namespace Decorator.Example.Decorators
{
    using System;
    using System.Collections.Generic;

    public class NullDecorator : IDecorator
    {
        public IEnumerable<Configuration> Decorate(IEnumerable<Configuration> configurations, string currency, string country, DateTime dateAdded)
        {
            return configurations;
        }
    }
}
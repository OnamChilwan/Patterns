namespace Decorator.Example.Decorators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultDecorator : IDecorator
    {
        private readonly IDecorator decorator;

        public DefaultDecorator(IDecorator decorator)
        {
            this.decorator = decorator;
        }

        public IEnumerable<Configuration> Decorate(IEnumerable<Configuration> configurations, string currency, string country, DateTime dateAdded)
        {
            var originalConfigs = new List<Configuration>(configurations);
            var filteredResult = this.decorator.Decorate(configurations, currency, country, dateAdded);

            if (filteredResult.Any())
            {
                return filteredResult;
            }

            return new List<Configuration> { originalConfigs.First() }; 
        }
    }
}
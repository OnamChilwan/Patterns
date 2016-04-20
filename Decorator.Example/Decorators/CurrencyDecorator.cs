namespace Decorator.Example.Decorators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CurrencyDecorator : IDecorator
    {
        private readonly IDecorator _decorator;

        public CurrencyDecorator(IDecorator decorator)
        {
            this._decorator = decorator;
        }

        public IEnumerable<Configuration> Decorate(
            IEnumerable<Configuration> configurations,
            string currency,
            string country,
            DateTime dateAdded)
        {
            return this._decorator
                .Decorate(
                    configurations,
                    currency,
                    country,
                    dateAdded)
                .Where(x => x.Currency == currency);
        }
    }
}
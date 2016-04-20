namespace Decorator.Example.Decorators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountryDecorator : IDecorator
    {
        private readonly IDecorator _decorator;

        public CountryDecorator(IDecorator decorator)
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
                .Where(x => x.Country == country);
        }
    }
}
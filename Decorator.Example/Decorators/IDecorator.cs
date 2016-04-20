namespace Decorator.Example.Decorators
{
    using System;
    using System.Collections.Generic;

    public interface IDecorator
    {
        IEnumerable<Configuration> Decorate(
            IEnumerable<Configuration> configurations,
            string currency,
            string country,
            DateTime dateAdded);
    }
}
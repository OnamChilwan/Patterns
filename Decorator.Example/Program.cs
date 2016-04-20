namespace Decorator.Example
{
    using System;
    using System.Collections.Generic;
    using Decorator.Example.Decorators;

    class Program
    {
        static void Main()
        {
            var configs = new List<Configuration>
            {
                new Configuration { Name = "Config 1", Country = "GB", Currency = "GBP" },
                new Configuration { Name = "Config 2", Country = "FR", Currency = "EUR" },
                new Configuration { Name = "Config 3", Country = "DE", Currency = "EUR" },
                new Configuration { Name = "Config 4", Country = "US", Currency = "USD" }
            };

			var results = 
                new DefaultDecorator(
                    new CurrencyDecorator(
			            new CountryDecorator(
			                new NullDecorator())))
                                .Decorate(configs, "GBP", "GB", DateTime.Now);

            foreach (var result in results)
            {
                Console.WriteLine("Name {0}, Country {1}", result.Name, result.Country);
            }

            Console.Read();
        }
    }
}
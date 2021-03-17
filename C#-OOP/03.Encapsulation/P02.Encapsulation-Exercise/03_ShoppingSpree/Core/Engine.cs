namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private readonly List<Person> people;
        private readonly List<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                AddPeople();
                AddProducts();

                string ordersInput = Console.ReadLine();

                while (ordersInput != "END")
                {
                    string[] args = ordersInput
                        .Split()
                        .ToArray();

                    string personName = args[0];
                    string productName = args[1];

                    Person targetPerson = people.FirstOrDefault(p => p.Name == personName);
                    Product targetProduct = products.FirstOrDefault(p => p.Name == productName);

                    if (targetPerson != null && targetProduct != null)
                    {
                        targetPerson.BuyProduct(targetProduct);
                    }

                    ordersInput = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    if (person.Products.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddProducts()
        {
            string[] productsInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var productCost in productsInput)
            {
                string[] args = productCost
                    .Split("=")
                    .ToArray();

                string name = args[0];
                decimal cost = decimal.Parse(args[1]);

                Product product = new Product(name, cost);

                this.products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] peopleInput = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var personBudget in peopleInput)
            {
                string[] args = personBudget
                    .Split("=")
                    .ToArray();

                string name = args[0];
                decimal money = decimal.Parse(args[1]);

                Person person = new Person(name, money);

                this.people.Add(person);
            }
        }
    }
}

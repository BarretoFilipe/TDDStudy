using System;

namespace BiggerAndSmallerClassLibrary
{
    public class Product : IEquatable<Product>
    {
        public Product(string nome, decimal valor)
        {
            Name = nome;
            Price = valor;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Product);
        }

        public bool Equals(Product other)
        {
            return other != null &&
                   Name == other.Name &&
                   Price == other.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
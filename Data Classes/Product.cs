using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class Product: IEquatable<Product>
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public bool Equals(Product other)
        {
            if (other is null)
                return false;

            return this.Name == other.Name && this.Code == other.Code;
        }

        public override bool Equals(object obj) => Equals(obj as Product);
        public override int GetHashCode() => (Name, Code).GetHashCode();

        public static List<Product> GetAllProducts()
        {
            return new List<Product>(){
                new Product { Name = "Orange", Code = 4 },
                new Product { Name= "Apple", Code = 9 },
                new Product { Name = "Banana", Code = 10 },
                new Product { Name = "Banana", Code = 10 },
                new Product { Name = "Banana", Code = 10 },
                new Product { Name = "Lemon", Code = 12 },
                new Product { Name = "Cherry", Code = 15 },
                new Product { Name = "Cherry", Code = 15 },
                new Product { Name = "Apricot", Code = 19 },
                new Product { Name = "Apricot", Code = 19 },
                new Product { Name = "Pear", Code = 21 },
            };
        }

        public static List<Product> GetAllSecondaryProducts()
        {
            return new List<Product>(){
                new Product { Name = "Orange", Code = 4 },
                new Product { Name= "Apple", Code = 9 },
                new Product { Name = "Banana", Code = 10 },
                new Product { Name = "Pear", Code = 21 },
                new Product { Name = "Watermelon", Code = 22 },
            };
        }
        
    }

}
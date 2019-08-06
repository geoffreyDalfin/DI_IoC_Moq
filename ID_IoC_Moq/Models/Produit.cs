using System;
namespace ID_IoC_Moq.Models
{
    public class Product
    {
        public string Name { get; internal set; }

        public Product(string name)
        {
            this.Name = name;
        }
    }
}

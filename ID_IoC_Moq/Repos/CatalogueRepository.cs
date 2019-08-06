using System;
using ID_IoC_Moq.Models;

namespace ID_IoC_Moq.Repos
{
    public interface ICatalog
    {
        Product GetProduct(string name);
    }

    public class CatalogueRepository : ICatalog
    {
        public CatalogueRepository()
        {
        }

        public Product GetProduct(string name)
        {
            return new Product(name);
        }
    }
}

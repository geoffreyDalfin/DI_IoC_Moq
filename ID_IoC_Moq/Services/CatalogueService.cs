using System;
using ID_IoC_Moq.Models;
using ID_IoC_Moq.Repos;

namespace ID_IoC_Moq.Services
{
    public class CatalogueService
    {
        private ICatalog _catalog;

        public CatalogueService(ICatalog catalog)
        {
            _catalog = catalog;
        }

        public string GetFavoriteProduct()
        {
            Product product = _catalog.GetProduct("Lit");
            return product.Name;
        }
    }
}

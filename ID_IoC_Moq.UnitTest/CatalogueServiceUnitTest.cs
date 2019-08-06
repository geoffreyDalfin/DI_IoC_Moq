using System;
using Autofac.Extras.Moq;
using ID_IoC_Moq.Models;
using ID_IoC_Moq.Repos;
using ID_IoC_Moq.Services;
using Moq;
using Xunit;

namespace ID_IoC_Moq.UnitTest
{
    public class CatalogueServiceUnitTest
    {
        [Fact]
        public void GetFavoriteProductTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange
                mock.Mock<ICatalog>().Setup(c => c.GetProduct(It.IsAny<string>())).Returns(new Product("test"));
                CatalogueService catalogueService = mock.Create<CatalogueService>();

                //act
                string name = catalogueService.GetFavoriteProduct();

                //assert
                Assert.Equal("test", name);
            }
        }
    }
}

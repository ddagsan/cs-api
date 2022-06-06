using NUnit.Framework;
using Services.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Controllers;
using Web.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Test.Controllers
{
    [TestFixture]
    public class ProductControllerTest// : BaseControllerTest
    {
        private SUTFactory factory;
        private ProductController _controller;
        private HttpClient _client;

        public ProductControllerTest()
        {
            factory = new SUTFactory();
            _client = factory.CreateClient();
        }

        [SetUp]
        public void Setup()
        {
            //base.SetUp();

            var productService = DependencyRegistrar.ServiceProvider.GetService<IProductService>();
            _controller = new ProductController(productService);
        }
        [Test]
        public async Task GetProductsUnsuccessfully()
        {
            var result = await _client.GetAsync($"/product");
            Assert.AreEqual(System.Net.HttpStatusCode.InternalServerError, result.StatusCode);
        }

        public static IEnumerable<TestCaseData> tcd
        {
            get
            {
                yield return new TestCaseData(new Dictionary<string, string>() {
                    { "name", "apple" },
                    { "colorid", "1" },
                    { "brand", "1" }
                });
                yield return new TestCaseData(new Dictionary<string, string>() {
                    { "name", "apple" },
                    { "colorid", "1" },
                    { "brand", "1" },
                    { "sorttype", "1" }
                });
                yield return new TestCaseData(new Dictionary<string, string>() {
                    { "name", "apple" },
                    { "colorid", "1" },
                    { "brand", "1" },
                    { "sorttype", "2" }
                });
                yield return new TestCaseData(new Dictionary<string, string>() {
                    { "name", "apple" },
                    { "colorid", "1" },
                    { "brand", "1" },
                    { "sorttype", "3" }
                });
                yield return new TestCaseData(new Dictionary<string, string>() {
                    { "name", "apple" },
                    { "colorid", "1" },
                    { "brand", "1" },
                    { "sorttype", "4" }
                });
            }
        }

        [Test]
        [TestCaseSource("tcd")]
        public async Task GetProductsSuccessfully(Dictionary<string, string> queryParams)
        {
            var result = await _client.GetAsync($"/product?index=0&size=12");
            var data = await result.Content.ReadAsStringAsync();
            var serializedData = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductSearchViewModel>(data);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
        }
    }
}

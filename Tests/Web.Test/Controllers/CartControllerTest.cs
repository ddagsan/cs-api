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
    public class CartControllerTest// : BaseControllerTest
    {
        private SUTFactory factory;
        private HttpClient _client;

        public CartControllerTest()
        {
            factory = new SUTFactory();
            _client = factory.CreateClient();
        }

        public const string Payload = "2";

        [Test]
        public async Task AddItemToCart()
        {
            HttpContent content = new StringContent(Payload, Encoding.UTF8, "application/json");

            var result = await _client.PostAsync($"/cart", content);
            var data = await result.Content.ReadAsStringAsync();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public async Task RemoveItemFromCart()
        {
            var result = await _client.DeleteAsync($"/cart?productId={Payload}");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public async Task GetItemsInCart()
        {
            var result = await _client.GetAsync($"/cart");
            Assert.AreEqual(System.Net.HttpStatusCode.InternalServerError, result.StatusCode);
        }        
    }
}

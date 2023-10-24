using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace blazorappdemo
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ProductService(HttpClient httpClient)
        {
            _client = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<Product>?> Get()
        {
            var response = await _client.GetAsync("v1/products");
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<Product>>(responseStream, _options);
        }

        public async Task Add(Product product)
        {
            var response = await _client.PostAsync("v1/products", JsonContent.Create(product));
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete(int productId)
        {
            var response = await _client.DeleteAsync($"v1/products/{productId}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<Product?> Get(int productId)
        {
            var response = await _client.GetAsync($"v1/products/{productId}");
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Product>(responseStream, _options);
        }

        public async Task Update(Product product)
        {
            var response = await _client.PutAsync($"v1/products/{product.Id}", JsonContent.Create(product));
            //# Body
            //{
            //    "title": "Change title",
            //    "price": 100
            //}
            response.EnsureSuccessStatusCode();
        }
    }

    public interface IProductService
    {
        Task<List<Product>?> Get();
        Task<Product?> Get(int productId);
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int productId);
    }
}

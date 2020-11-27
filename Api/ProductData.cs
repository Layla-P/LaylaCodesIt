using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public interface IProductData
    {
        Task<Blog> AddProduct(Blog product);
        Task<bool> DeleteProduct(int id);
        Task<IEnumerable<Blog>> GetProducts();
        Task<Blog> UpdateProduct(Blog product);
    }

    public class ProductData : IProductData
    {
        private readonly List<Blog> products = new List<Blog>
        {
            new Blog
            {
                Id = 10,
                Name = "Strawberries",
                Description = "16oz package of fresh organic strawberries",
                Quantity = 1
            },
            new Blog
            {
                Id = 20,
                Name = "Sliced bread",
                Description = "Load of fresh sliced wheat bread",
                Quantity = 1
            },
            new Blog
            {
                Id = 30,
                Name = "Apples",
                Description = "Bag of 7 fresh McIntosh apples",
                Quantity = 1
            }
        };

        private int GetRandomInt()
        {
            var random = new Random();
            return random.Next(100, 1000);
        }

        public Task<Blog> AddProduct(Blog product)
        {
            product.Id = GetRandomInt();
            products.Add(product);
            return Task.FromResult(product);
        }

        public Task<Blog> UpdateProduct(Blog product)
        {
            var index = products.FindIndex(p => p.Id == product.Id);
            products[index] = product;
            return Task.FromResult(product);
        }

        public Task<bool> DeleteProduct(int id)
        {
            var index = products.FindIndex(p => p.Id == id);
            products.RemoveAt(index);
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Blog>> GetProducts()
        {
            return Task.FromResult(products.AsEnumerable());
        }
    }
}

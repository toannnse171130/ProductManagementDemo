﻿using BusinessObjects;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;

        public ProductService()
        {
            iProductRepository = new ProductRepository();
        }

        public void SaveProduct(Product p)
        {
            iProductRepository.SaveProduct(p);
        }

        public void DeleteProduct(Product p)
        {
            iProductRepository.DeleteProduct(p);
        }

        public Product GetProductById(int id)
        {
            return iProductRepository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        public void UpdateProduct(Product p)
        {
            iProductRepository.UpdateProcut(p);
        }
    }
}

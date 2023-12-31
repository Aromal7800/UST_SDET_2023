﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_oct_30
{
    internal class ProductManagement<T>
    {
        private List<Product<T>> products= new List<Product<T>>();
        public void AddProduct(Product<T> product)
        {
            products.Add(product);
        }
        public void UpdateProduct(int productId, Product<T> updatedProduct)
        {
            var productToUpdate=products.Find(x=>x.ProductID==productId);
          //  Console.WriteLine(updatedProduct.ProductID + "  " + updatedProduct.Name + "   " + updatedProduct.Price + "   " + updatedProduct.QuantityInStock);


            if (productToUpdate!=null)
            {
                productToUpdate.ProductID=updatedProduct.ProductID;
                productToUpdate.Name=updatedProduct.Name;
                productToUpdate.Price=updatedProduct.Price;
                productToUpdate.QuantityInStock=updatedProduct.QuantityInStock;

            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
        public void DeleteProduct(int productId)
        {
          products.RemoveAll(x=>x.ProductID == productId);
        }
        public void DisplayProducts()
        {
            foreach(var product in products)
            {
                Console.WriteLine(product.ProductID+"  "+ product.Name+ "   "+ product.Price+"   "+product.QuantityInStock);
            }
        }
    }
}

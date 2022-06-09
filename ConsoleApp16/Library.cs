using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    internal class Library
    {
        Product[] Products = new Product[0];
        public void AddProduct(Product prd)
        {
            Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length-1] = prd;
        }
        public int GetJournalsCount()
        {
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Journal)
                {
                    count++;
                }
            }
            return count;
        }
        public int GetBooksCount()
        {
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Book)
                {
                    count++;
                }
            }
            return count;
        }

        public Product[] GetProducts(bool isBook)
        { 
            Product[] products = new Product[0];
            if (isBook)
            {
                foreach (var item in Products)
                {
                    if (item is Book)
                    {
                        Array.Resize (ref products, products.Length+1);
                        products[products.Length-1] = item;
                    }
                }
            }
            else if (!isBook)
            {
                foreach (var item in Products)
                {
                    if (item is Journal)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = item;
                    }
                }
            }
            
              
            

            return products;
        }
    }
}

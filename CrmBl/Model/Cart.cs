using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model
{
    public class Cart : IEnumerable
    {
        public Customer Customer { get; set; }
        public Dictionary<Product, int> Products { get; set; }
        public Cart(Customer customer)
        {
            Customer = customer;
            Products = new Dictionary<Product, int>();
        }
        //метод добавления товара в корзину
        public void Add(Product product)
        {
            if(Products.TryGetValue(product, out int count)) 
            {
                Products[product] = ++count; //увеличим количество этого продукт, не добавляя его еще раз
            }
            //если такого продукта нет, то добавляем
            else
            {
                Products.Add(product, 1);
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var product in Products.Keys)
            {
                for(int i = 0; i < Products[product]; i++)
                {
                    yield return product;
                }
            }
        }
        public List<Product> GetAll()
        {
            var result = new List<Product>();
            foreach(Product i in this )
            {
                result.Add(i);
            }
            return result;
        }
    }
}

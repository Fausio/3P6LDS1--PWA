using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        //        Exercícios:
        //              Fazer um programa que, a partir de uma lista de produtos, 
        //            calcule a soma dos preços somente dos produtos cujo nome começa com "T".

        class Product
        {
            public string name;
            public double price;

            public Product(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        }

        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            list.Sort((p1, p2) => p1.name.ToUpper().CompareTo(p2.name.ToUpper()));

            var sum = list.Aggregate(0.0, (x, y) => x + y.price);
        }


        static string total_price_with_T_product(List<Product> model)
        {
            // result variable

            List<Product> productResult = new List<Product>();

            model.ForEach(x =>
            {
                //  get fist character of string 
                string fistString = x.name.Substring(0, 1);

                //  sum values of T product name
                if (fistString.Contains("t") || fistString.Contains("T"))
                {
                    productResult.Add(x);
                }

            });

            return productResult.Aggregate(0.0, (x, y) => x + y.price).ToString();
        }

    }
}

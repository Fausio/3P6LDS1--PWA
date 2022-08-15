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

        delegate int delegado(int i);

        static void Main(string[] args)
        {
            delegado meuDelegate = x => x * x;
            int valor = meuDelegate(5);
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

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
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            Console.WriteLine("Print result: \n " + total_price_with_T_product(list));

        }


        static string total_price_with_T_product(List<Product> model)
        {
            // result variable
            double TotalResult = 0;

            model.ForEach(x =>
            {
                //  get fist character of string 
                string fistString = x.name.Substring(0, 1);

                //  sum values of T product name
                if (fistString.Contains("t") || fistString.Contains("T"))
                {
                    TotalResult += x.price;
                }

            });

            return TotalResult.ToString();
        }

    }
}

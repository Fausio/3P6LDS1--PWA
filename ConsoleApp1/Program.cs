using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        //   Exercícios:
        //   Fazer um programa que, a partir de uma lista de produtos, 
        //   calcule a soma dos preços somente dos produtos cujo nome começa com "T".

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Tier { get; set; }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public Category Category { get; set; }
            public override string ToString()
            {
                return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
            }
        }


        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {


            var a = "Detalhe do Beneficiário: https://bo.medihealth.co.mz:443/KISL/Beneficiary/Details/164904";
            int start = a.IndexOf(":443");
            string b = a.Remove(start, 4);
        }



        static string total_price_with_T_product(List<Product> model)
        {
            model.RemoveAll(startWithT);
            return model.Aggregate(0.0, (x, y) => x + y.Price).ToString();
        }


        public static bool startWithT(Product model)
        {
            try
            {
                //  get fist character of string 
                string fistString = model.Name.Substring(0, 1);

                //  sum values of T product name
                if (fistString.Contains("t") || fistString.Contains("T"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.Write("Erro ao tentar determinar a primeira letra ", ex);
                throw;
            }

        }

    }
}

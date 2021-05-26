using System;
using System.Collections.Generic;

namespace T2009M
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> productList = new List<Product>();
        private string city;
        private string country;

        public Cart()
        {

        }

        public Cart(int id, string customer, double grandTotal, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public Product this[int index]
        {
            get => productList[index];
            set => productList[index] = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public void AddNewProduct(Product prd)
        {
            productList.Add(prd);
        }

        public void RemoveProduct(Product prd)
        {
            productList.Remove(prd);
        }

        public void GetProductInCart()
        {
            foreach (Product prod in productList)
            {
                Console.WriteLine("\t ");
                prod.GetInfo();
            }
        }

        public double CalcGrandTotal()
        {
            if (City == "HN" || City == "HCM")
            {
                GrandTotal = GrandTotal + GrandTotal * 1 / 100;
            }
            else if (Country == "Vietnam")
            {
                GrandTotal = GrandTotal + GrandTotal * 2 / 100;
            }
            else
            {
                GrandTotal = GrandTotal + GrandTotal * 5 / 100;
            }

            return GrandTotal;
        }


    }
}
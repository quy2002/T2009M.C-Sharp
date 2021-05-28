using System;
using System.Collections.Generic;

namespace T2009M
{
    public delegate void ShowMessage(string s);
    public class Cart
    {

        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> productList = new List<Product>();
        private string city;
        private string country;
        public event ShowMessage ShowEvent;

        public Cart()
        {

        }

        public Cart(int id, string customer, string city, string country)
        {
            this.id = id;
            this.customer = customer;
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
            ShowEvent = AlertMessage;
            ShowEvent("Ban vua them san pham " + prd.Name + " vao gio hang");
        }

        public void RemoveProduct(Product prd)
        {
            productList.Remove(prd);
            ShowEvent = AlertMessage;
            ShowEvent("Ban vua xoa san pham " + prd.Name);
        }

        public void AddQuantityProduct(Product prd, int qty)
        {
            prd.Quantity += qty;
            ShowEvent = AlertMessage;
            ShowEvent("Ban vua tang so luong san pham " + prd.Name + " them " + qty);
        }

        public void DecreaseQuantityProduct(Product prd, int qty)
        {
            if (prd.Quantity > 1 && qty < prd.Quantity && qty > 0)
            {
                prd.Quantity -= qty;
                ShowEvent = AlertMessage;
                ShowEvent("Ban vua giam so luong san pham " + prd.Name + " di " + qty);
            }
            else
            {
                Console.WriteLine("Giam so luong san pham khong thanh cong");
            }
        }

        public void GetProductInCart()
        {
            foreach (Product prod in productList)
            {
                Console.WriteLine("Ten san pham: " + prod.Name + " -- " + " Gia: " + prod.Price + " -- " + "So luong: " + prod.Quantity);
            }
        }

        public double CalcGrandTotal()
        {
            foreach (Product prod in productList)
            {
                GrandTotal += prod.Quantity * prod.Price;
            }
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

        public static void AlertMessage(string sm)
        {
            Console.WriteLine("Message: " + sm);
        }





    }
}
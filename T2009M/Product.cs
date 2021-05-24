using System;
using System.Collections.Generic;

namespace T2009M

{
    public class Product
    {
        private int id;
        private string name;
        private float price;
        private int quantity;
        private string image;
        private string desc;
        private List<string> gallery = new List<string>();

        public Product()
        {
        }

        public Product(int id, string name, float price, int quantity, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.image = image;
            this.desc = desc;
            this.gallery.Add(image);
        }

        public void GetInfo()
        {
            Console.WriteLine("id: " + this.id);
            Console.WriteLine("ProductName: " + this.name);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Quantity: " + this.quantity);
            Console.WriteLine("Image: " + this.image);
            Console.WriteLine("Desc: " + this.desc);
            Console.WriteLine("Gallery: " + this.gallery);
            foreach (string image in gallery)
            {
                Console.WriteLine(image);
            }

        }

        public void NotificationQuantity()
        {
            if (this.quantity > 0)
            {
                Console.WriteLine("In stock");
            }
            else if (this.quantity == 0)
            {
                Console.WriteLine("Out of stock");
            }
        }

        public void AddImageToGallery()
        {
            if (this.gallery.Count < 10)
            {
                Console.WriteLine("Add new image to gallery");
                string image = Convert.ToString(Console.ReadLine());
                this.gallery.Add(image);

            }
            else
            {
                Console.WriteLine("Can't add image to gallery");
            }

        }

        public void DeleteImageInGallery()
        {
            Console.WriteLine("Chon anh so may de xoa");
            int n = Convert.ToInt32(Console.ReadLine());
            this.gallery.Remove(this.gallery[n - 1]);
        }
    }
}
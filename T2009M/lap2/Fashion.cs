using System;

namespace T2009M
{
    public class Fashion : Product
    {
        private string color;
        private string size;


        public Fashion()
        {
        }

        public Fashion(int id, string name, float price, int quantity, string image, string desc, string color, string size) : base(id, name, price, quantity, image, desc)
        {
            this.color = color;
            this.size = size;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Mau sac : " + this.color);
            Console.WriteLine("Size: " + this.size);
        }

        public void NotificationQuantity()
        {
            base.NotificationQuantity();
        }

        public void AddImageToGallery()
        {
            base.AddImageToGallery();
        }

        public void DeleteImageInGallery()
        {
            base.AddImageToGallery();
        }

        public Boolean CheckStatusProduct(string color, string size)
        {
            if (this.color == color && this.size == size) return true;
            return false;
        }

        public void CheckInStock(string color, string size)
        {
            if (CheckStatusProduct(color, size))
            {
                Console.WriteLine("Sản phẩm còn hàng");
            }
            else
            {
                Console.WriteLine("Sản phẩm đã hết hàng");
            }
        }
    }
}
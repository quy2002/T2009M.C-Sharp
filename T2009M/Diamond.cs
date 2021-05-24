using System;

namespace T2009M
{
    public class Diamond : Product
    {
        private int cara;

        public Diamond()
        {
        }

        public Diamond(int id, string name, float price, int quantity, string image, string desc, int cara) : base(id, name, price, quantity, image, desc)
        {
            this.cara = cara;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("So cara : " + this.cara);
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

        public void CheckRealDiamond()
        {

        }




    }
}
namespace T2009M

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Product prod = new Product(1, "Iphone", 2000, 5, "image1", "SmartPhone");
            prod.GetInfo();
            prod.NotificationQuantity();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.DeleteImageInGallery();
            prod.GetInfo();
        }
    }
}
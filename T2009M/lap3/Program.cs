using System;

namespace T2009M
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Diamond dim = new Diamond(1, "Diamond Black", 10000, 1, "diamond.png", "This is a black diamond", 20);
            Fashion fs1 = new Fashion(2, "T-Shirt", 2000, 2, "t-shirt.jpg", "This is T-shirt", "red", "XL");
            Fashion fs2 = new Fashion(3, "Adidas Ultraboost", 5000, 1, "ultraboot.png", "This is Ultraboost", "black", "44");
            Cart ca = new Cart(1, "Dang Jinner", 14000, "Ninh Binh", "Vietnam");
            ca.AddNewProduct(dim);
            ca.AddNewProduct(fs1);
            ca.AddNewProduct(fs2);
            ca.RemoveProduct(fs2);
            Console.WriteLine("ID khach hang: " + ca.Id);
            Console.WriteLine("Ten khach hang: " + ca.Customer);
            Console.WriteLine("Thanh pho: " + ca.City);
            Console.WriteLine("Quoc gia: " + ca.Country);
            Console.WriteLine("Gio hang: ");
            Console.WriteLine("---------------");
            ca.GetProductInCart();
            Console.WriteLine("---------------");
            Console.WriteLine("Tong tien la: " + ca.CalcGrandTotal());

        }
    }
}
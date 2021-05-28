using System;

namespace T2009M
{
    public delegate int ShowResult(int a, int b);
    public class Program

    {
        public static ShowResult result = new ShowResult(CalcInt.PhepCong);
        public static void Main(string[] args)
        {
            result += CalcInt.PhepCong;
            result += new CalcInt().PhepChia;
            result += new CalcInt().PhepNhan;
            result += new CalcInt().PhepChia;
            int rs = result(5, 4);
            Console.WriteLine("Ket qua: " + rs);

        }
    }
}
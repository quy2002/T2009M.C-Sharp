using System;
using System.Threading;

namespace T2009M.lab.s5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread boom = new Thread(Boom);
            boom.Start();

        }

        public static void Boom()
        {
            int min = 10;
            int sec = 0;
            while (min >= 0)
            {
                if (sec == 0)
                {
                    sec = 60;
                    min--;
                }
                sec--;
                if (min < 10)
                {
                    if (sec < 10)
                    {
                        Console.WriteLine("0" + min + ":" + "0" + sec);
                    }
                    else
                    {
                        Console.WriteLine("0" + min + ":" + sec);
                    }
                }

                if (min == 0 && sec == 0) Console.WriteLine(" ***** Bùmmmmmmm *****");

                try
                {
                    Thread.Sleep(10);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }


            }

        }
    }


}
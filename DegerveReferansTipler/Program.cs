﻿namespace DegerveReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int, decimal, float, double, bool(true 1 , false 0 ) DEĞER TİP!!!
            //Array, interface, class REFERANS TİP !!!
            Console.WriteLine("Hello, World!");

            //DEĞER TİP
            int sayi1= 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??? 30

            //REFERANS TİP
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
                //sayilar1[0] ??? 999

        }
    }
}
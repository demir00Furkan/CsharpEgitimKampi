using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 

            //for(x;y;z)
            //x:Başlangıç
            //y:bitiş
            //z:Artış-azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen Adedi Girin");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion
            #region For Dögüsü İle Karar Yapıları

            //for (int i = 0; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int Toplam=0 , GirilenSayi;
            //Console.Write("Lütfen Sayı Giriniz");
            //GirilenSayi = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= GirilenSayi; i++)
            //{
            //    Toplam = Toplam + i;

            //}
            //Console.Write(Toplam);

            //int Toplam =0 ;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Toplam = Toplam + i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(Toplam);

            //int count = 0;
            //for (int i = 1; i <= 28; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);



            //int bacterium = 1;
            //for (int i = 1; i<=24;i++)
            //{
            //    bacterium = bacterium * 2;
            //    Console.WriteLine(i + ". Saat Sonunda " + bacterium);
            //}

            #endregion
            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10) 
            //{
            //    sum= sum+i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //Console.Write("Sayi girin");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //tens = (number % 100)/10;
            //hundreds = number / 100;
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds; 
            //Console.WriteLine(sum);


            #endregion
        }
    }
}

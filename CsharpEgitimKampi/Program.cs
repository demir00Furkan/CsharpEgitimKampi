using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //Console.WriteLine("Selam");
            //Console.Write("Merhaba Dünya");

            //Console.WriteLine("------- Yemek Kategorileri******");
            //Console.WriteLine("1-Çorbalar");
            #endregion
            #region String Degişkenler
            //string
            //Değişken türü değiken Adı

            //string name;
            //name = "Murat";
            //Console.Write(name);


            //string custommerName, custommerSurname, custommerPhone, custommerEmail, district, city;
            //custommerName = "Ali";
            //custommerSurname = "Çınar";
            //custommerPhone = "+90 500 20 10";
            //custommerEmail = "Deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("*****Rezervasyon Kartı*****");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müşteri: "+ custommerName+ " " +  custommerSurname);
            //Console.WriteLine("İletişim: " + custommerPhone);
            //Console.WriteLine("Email Adresi: "+ custommerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            #endregion
            #region int Degiskenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cookePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonatePrice = 30;
            Console.WriteLine("*****Restoran Menu Fiyatı*****");
            Console.WriteLine();
            Console.WriteLine("--------Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("--------Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("--------Limonata: " + lemonatePrice + " TL");
            Console.WriteLine("--------Kola: " + cookePrice + " TL");
            Console.WriteLine("--------Kızartma: " + friesPrice + " TL");
            Console.WriteLine("--------Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("*****Restoran Menu Fiyatı*****");

            Console.WriteLine();
            int HamburgerCount = 3;
            int cookeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonateCount = 0;

            int TotalHamburgerPrice;
            int TotalCookePrice;
            int TotalWaterPrice;
            int TotalFriesPrice;
            int TotalPizzaPrice;
            int TotalLemonatePrice;



            TotalHamburgerPrice = HamburgerCount * hamburgerPrice;
            TotalCookePrice = cookeCount * cookePrice;
            TotalWaterPrice = waterCount * waterPrice;
            TotalLemonatePrice = lemonateCount * lemonatePrice;
            TotalFriesPrice = friesCount * friesPrice;
            TotalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Hamburger Tutarı: " + TotalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + TotalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + TotalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + TotalCookePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + TotalLemonatePrice + " TL");
            Console.WriteLine("Su Tutarı: " + TotalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = TotalCookePrice + TotalFriesPrice + TotalHamburgerPrice + TotalLemonatePrice + TotalWaterPrice + TotalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);





            #endregion
        }
    }
}

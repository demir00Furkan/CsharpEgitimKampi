using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else
            //Console.Write("Lüfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Ülkeyi Giriniz");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doprulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}
            //int number;
            //Console.Write("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Hatalı");
            //}

            //int exam1 , exam2 , exam3, avarage ;
            //string result="Hata";
            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //avarage = (exam1+exam2 + exam3)/3;
            //Console.WriteLine("Sınavların Ortalaması: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "sonuç Orta";
            //}
            //if(avarage > 70 & avarage<=90)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (avarage > 90 & avarage <= 100)
            //{
            //    result = "Sonuç Pek İyi";
            //}


            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen Büyük Harfle Şehir Girişi Yapınız");
            //city = Console.ReadLine();

            //if (city == "Adana" | city == "Bursa" | city == "Diyarbakır")
            //{
            //    Console.WriteLine("Şehir Mevcut");

            //}
            //else 
            //{ 
            //    Console.WriteLine("Şehir Mevut Değil");
            //}


            //Console.WriteLine("Lütfen Kullanıcı Adını Giriniz");
            //string username = Console.ReadLine();


            //if (username != "admin2121")
            //{
            //    Console.WriteLine("Bu kullanıcı Adı Kabul Edilemez");

            //}

            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}


            //Console.Read();
            #endregion
            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1.sayiyi giriniz");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sayiyi giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1.sayinin 2. sayıya bölümünden kalan: "+ result);

            //Console.Write("lütfen sayi girin");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayi çifttir");

            //}
            //else
            //{
            //    Console.WriteLine("Sayi Tektir");
            //}
            #endregion
            #region Char Değikenler İle Karar Yapıları
            //Console.Write("Lütfen Takımın Baş Harfini Büyük Harfle Giriniz");
            //char karakter = char.Parse(Console.ReadLine());
            //if (karakter == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (karakter == 'A')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (karakter == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            #endregion
            #region Örnek Proje uygulaması

            //Console.WriteLine("------ C# Eğitim Kampı ------");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------");

            //Console.Write("Detayını Görmek İstediğiniz Menüyü Seçin");
            //string MenuItem = Console.ReadLine();
            //if (MenuItem == null) 
            //{
            //    Console.WriteLine("Bir Değer Girmediniz");

            //}
            //if (MenuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Ana Yemekler ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("---------------- Ana Yemekler ----------------");
            //    Console.WriteLine();

            //}

            //if (MenuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Çorbalar ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mecimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("---------------- Çorbalar ----------------");
            //    Console.WriteLine();

            //}

            //if (MenuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Pizzalar ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("---------------- Pizzalar ----------------");
            //    Console.WriteLine();

            //}

            //if (MenuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- İçecekler ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("---------------- İçecekler ----------------");
            //    Console.WriteLine();

            //}

            //if (MenuItem == "5")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("---------------- Tatlılar ----------------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Triliçe");
            //        Console.WriteLine("2-Kazandibi");
            //        Console.WriteLine("3-Sütlaç");
            //        Console.WriteLine("---------------- Tatlılar ----------------");
            //        Console.WriteLine();

            //    }
            #endregion
            #region Swich Case
            //Console.Write("Lütfen Ay Girin: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break ;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Haziran"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi Yapıldı"); break;   
            //}


            #endregion
            #region Switch Case Hesap Makinesi

            double number1, number2, result;
            char symbol;
            Console.Write("1.sayiyi Girin");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("2.sayiyi Girin");
            number2 = double.Parse(Console.ReadLine());
            Console.Write("yapmak istediğiniz işlemin sembolünü Girin");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result); break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result); break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result); break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result); break;

            }


            #endregion
        }
    }
}

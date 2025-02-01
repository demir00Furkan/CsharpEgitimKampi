using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye değer döndürmeyen metotlar
            //customer- listele, ekle, sil, güncelle

            //void custommerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Buse Çınar");
            //}
            //custommerList();
            //custommerList();
            //custommerList();
            //custommerList();

            //void Sum()
            //{
            //    int x = 1, y = 2, z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion
            #region Geriye Değer Döndürmeyen String Parametleri Metotlar

            //void WriteMethod(string custommerName)
            //{
            //    Console.WriteLine(custommerName);
            //}
            //WriteMethod("Mehmet Yılmaz");

            //void CustommerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);

            //}
            //CustommerCard("Mehmet", "Yıldız");
            //CustommerCard("Ayşegül", "Kaya");
            #endregion
            #region Geriye Değer Döndürmeyen int Parametleri Metotlar

            //void sum(int number1, int number2, int number3)
            //{
            //    int result=number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4,5,6);

            #endregion
            #region Geriye Değer Döndüren Metotolar

            //string custommerName()
            //{
            //    return "Buse Yıldız";
            //}

            //custommerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());
            #endregion
            #region Geriye Değer String Döndüren Parametreli Metotlar

            //string countryCard(string countryName, string Capital, string FlagColor)
            //{
            //    string cardInfo = " Ülke: " + countryName + " - Başkent: " + Capital + " - Bayrak Rengi: " + FlagColor;

            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(countryCard(x, y, z));
            #endregion
            #region Geriye Değer Int Döndüren Parametreli Metotlar

            //int sum(int number1, int number2)
            // {
            //     int result = number1 + number2;
            //     return result;
            // }
            // Console.WriteLine(sum(45, 98));
            // Console.WriteLine(sum(36, 25));
            // Console.WriteLine(sum(44, 36));
            // Console.WriteLine(sum(14, 20));
            #endregion
            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti"+ "Ortalama: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci Başarısız Oldu" + "Ortalama: " + result;
                }
                
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2, 4, 6, 8 
            // sari, kırmızı, mavi, turuncu, beyaz
            //adana, ankara, istanbul, bursa
            //değişkentürü [] DiziAd = new DeğişkenTürü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[2]);

            //string[] city = new string[5];
            //city[0] = "Milano";
            //city[1] = "Budapeşte";
            //city[2] = "Lyon";
            //city[3] = "Kahire";
            //city[4] = "Üsküp";
            //Console.WriteLine(city[0]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Bursa" };
            //Console.WriteLine(cities[1]);

            #endregion
            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = { 4, 458, 87, 245, 444, 658, 22, 1120, 91 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symblos = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symblos.Length; i++)
            //{
            //    Console.WriteLine(symblos[i]);
            //}

            //int[] MyArray = { 47, 85, 95, 41, 25, 635,789, 86, 100 };

            //int maxNumber= MyArray[0];
            //for (int i = 0; i < MyArray.Length; i++)
            //{
            //    if( MyArray[i] > maxNumber )
            //    {
            //        maxNumber = MyArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ayşe", "ahmet", "buse", "ceyda", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 40, 78, 99, 112 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 40, 78, 99, 112 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region dizi metotlar

            //string[] customers = { "ali", "ayşe", "ayşegül", "buse", "yusuf" };
            //int index = Array.IndexOf(customers, "ayşegül");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 65, 89, 44, 12, 112, 369, 421, 444 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() +" Dizinin En Küçük Elemanı: " + numbers.Min());


            #endregion
            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen{i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 60, };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("TekSayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
        }
    }
}

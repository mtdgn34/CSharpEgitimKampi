using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        private static object console;

        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            //geriye değer döndürmeyen metotlar
            //Customer-listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye değer döndürmeyen parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard (string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " " + " - Başkent: " + capital + " " + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //Console.Write("Ülke Adını Giriniz: ");
            //string x, y, z;
            //x = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");       
            //y = Console.ReadLine(); 

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));   

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum (int number1, int number2)
            //{
            //    int result= number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));


            #endregion

            #region Örnek Uygulama
                        
            string ExamResult (string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return student + " isimli Öğrenci sınavı geçti "+"Ortalama: "+result;
                }
                else
                {
                    return student + " isimli Öğrenci başarısız oldu "+"Ortalama: "+ result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe",36,88,33));

            #endregion


            Console.Read();
        }
    }
}

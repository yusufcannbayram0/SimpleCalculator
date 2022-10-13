using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger1, deger2;
            int islem;
            int x, y = 0;
            Random random = new Random();
            Calculator calculator = new Calculator();
            Console.WriteLine("( Toplama : + ) ( Çıkarma : - ) ( Çarpma : * ) ( Bölme : / )");
            Console.Clear();
            while (true)
            {
                deger1 = random.Next(0, 100);//rastgele değerler
                deger2 = random.Next(0, 100);
                islem = random.Next(1, 4); // 4 islemden rastgele birini seçiyor
                x = random.Next(0, Console.WindowWidth); // x ekseninde console ekranının genişliğine göre rastgele pozisyon değeri atanır
                y = random.Next(0, Console.WindowHeight);// y ekseninde console ekranının yüksekliğine göre rastgele pozisyon değeri atanır
                Console.ForegroundColor = (ConsoleColor)random.Next(1, 16); // rastgele metin rengi atama
                Console.Clear();
                Console.SetCursorPosition(x, y); // x , y rastgele poziyonlarını konsolda tanımlama
                switch (islem)
                {
                    case 1:
                        Console.WriteLine("Sonuç : " + calculator.Topla(deger1,deger2));
                        break;
                    case 2:
                        Console.WriteLine("Sonuç : " + calculator.Çıkar(deger1, deger2));
                        break;
                    case 3:
                        Console.WriteLine("Sonuç : " + calculator.Çarp(deger1, deger2));
                        break;
                    case 4:
                        Console.WriteLine("Sonuç : " + calculator.Böl(deger1, deger2));
                        break;
                    default:
                        Console.WriteLine("( Toplama : + ) ( Çıkarma : - ) ( Çarpma : * ) ( Bölme : / )");
                        break;
                }
                Thread.Sleep(200);//200 milisaniye bekleme -> bunu kullanabilmek için using System.Threading eklenmesi gerekmektedir
            }



            Console.ReadLine();
        }
    }
    class Calculator // hesaplama sınıfı oluşturuldu
    {
        public double Topla(double deger1, double deger2)
        {
            return deger1 + deger2;
        }
        public double Çıkar(double deger1, double deger2)
        {
            return deger1 - deger2;
        }
        public double Çarp(double deger1, double deger2)
        {
            return deger1 * deger2;
        }
        public double Böl(double deger1, double deger2)
        {
            return deger1 / deger2;
        }
    }
}

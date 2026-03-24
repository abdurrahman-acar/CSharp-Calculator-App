using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace Çalışma
{
    internal class Program
    {
        static char tercih = ' ';
        static double sonuc = 0;
        static double sayi1 = 0;
        static double sayi2 = 0;
        static char secim = ' ';

        static void Main(string[] args)
        {

            Console.WriteLine("\n1. Sayıyı Giriniz : ");
        sayi1:
            try
            {

                sayi1 = Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\n1. Sayı İçin Lütfen Geçerli Bir Değer Giriniz :");
                goto sayi1;
            }



            Console.WriteLine("\n2. Sayıyı Giriniz : ");
        sayi2:
            try
            {
                sayi2 = Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\n2. Sayı İçin Lütfen Geçerli Bir Değer Giriniz :");
                goto sayi2;
            }


            Console.WriteLine("\nHangi İşlemi Yapmak İstediğinizi Giriniz : '+' , '-' , '/' , '*' , '%' ");
        secim:
            try
            {
                secim = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nİşlem İçin Lütfen '+' , '-' , '*' , '/' , '%' Değerlerinden Birini Giriniz\n");
                goto secim;
            }

            if (secim != '+' && secim != '*' && secim != '/' && secim != '-' && secim != '%')
            {
                Console.WriteLine("\nİşlem İçin Lütfen '+' , '-' , '*' , '/' , '%' Değerlerinden Birini Giriniz\n");
                goto secim;
            }

            Console.WriteLine(Islem(sayi1, sayi2, secim));
            do
            {


                Console.WriteLine("\nİşleme Devam Etmek İstiyor Musun? Evet : e , Hayır : h");
            tercih:
                try
                {
                    tercih = char.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nLütfen 'e' yada 'h' Değerlerinden Birini Giriniz");
                    goto tercih;
                }

                if (tercih != 'e' && tercih != 'h')
                {
                    Console.WriteLine("\nLütfen 'e' yada 'h' Değerlerinden Birini Giriniz");
                    goto tercih;
                }

                if (tercih == 'h')
                {
                    Console.WriteLine("Program Sonlandırılıyor...");
                    Environment.Exit(0);
                }


                Console.WriteLine(IslemDevam(tercih, sayi1));
            } while (secim != 'h');
            }

        #region Islem
        static double Islem(double sayi1 , double sayi2 , char secim)
        {
            switch (secim)
            {
                case '+':
                    sayi1 += sayi2;
                    break;

                case '-':
                    sayi1 -= sayi2;

                    break;

                case '*':
                    sayi1 *= sayi2;

                    break;

                case '/':
                    sayi1 /= sayi2;

                    break;

                case '%':
                    sayi1 %= sayi2;
                    break;
            }

            return sayi1;
        }
        #endregion



        #region İşlemDevam
        static double IslemDevam(char tercih ,double sayi1)
        {
        baslangıc:
            Console.WriteLine("\nDevam Edilecek Sayıyı Giriniz : ");
            double sayi2 = Double.Parse(Console.ReadLine());


        Islem:
            Console.WriteLine("\nHangi İşlemi Yapmak İstediğinizi Giriniz : '+' , '-' , '/' , '*' , '%' ");
            char secim = char.Parse(Console.ReadLine());


            if (secim != '+' && secim != '*' && secim != '/' && secim != '-' && secim != '%')
            {
                Console.WriteLine("\nİşlem İçin Lütfen Geçerli Bir Değer Giriniz");
                goto Islem;
            }

            if (sayi1 == 0 || sayi2 == 0 && secim == '/')
            {
                Console.WriteLine("\n0 İle Bölme İşlemi Yapılamaz Lütfen Geçerli İşlem Veya Sayı Giriniz\n");
                goto baslangıc;
            }

            switch (secim)
            {
                case '+':
                    sayi1 += sayi2;
                    break;

                case '-':
                    sayi1 -= sayi2;

                    break;

                case '*':
                    sayi1 *= sayi2;

                    break;

                case '/':
                    sayi1 /= sayi2;

                    break;

                case '%':
                    sayi1 %= sayi2;
                    break;

                default:
                    Console.WriteLine("Geçerli Bir İslem Giriniz");
                    goto Islem;
            }

            return sayi1;
            
            
    }
        
        #endregion

    }
}

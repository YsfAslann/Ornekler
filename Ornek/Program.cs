using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Kdv'li fiyat hesaplama\n"+
                             "2. Girilen sayının kendine kadar ki  toplamı hesaplama\n" +
                             "3. Polindron sayı bulma\n" +
                             "4. Dikdörtgen alan ve çevre hesaplama\n"+     
                             "5. Klavyeden girilen 3 sayının en büyük ve en küçük olanını toplamını bulma\n"+
                             "6. Girilen 2 tam sayının toplamı\n"+    
                             "7. Girilen 3 sayının ortalaması bulma\n" +
                             "8. Girilen sayının 3/2 sini bulma\n" +
                             "9. Matris köşegen toplamı bulma\n" +
                            "10. Mtv tutar hesaplama\n");


            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    KdvliFiyat();
                    break;
                 case 2:
                    SayiToplamı();
                    break;
                case 3: 
                    PolidronSayi();
                    break;
                case 4:
                    DikdörtgenAlan();
                    break;                             
                case 5:
                    EnBüyükVeEnKücük();
                    break;
                case 6:
                    İkiTamSayıToplamı();
                    break;
                case 7:
                    OrtalamaHesaplama();
                    break;
                case 8:
                    ÜçteİkisininToplamı();
                    break;
                case 9:
                    MatrisSayi();
                    break;
                case 10:
                    MtvOdemesi();
                    break;




            }

        }


        private static void KdvliFiyat()
        {
            Console.WriteLine("Lütfen ürünün fiyatını giriniz");
            double para = Convert.ToDouble(Console.ReadLine());
            double s1 = para * 0.18;
            double toplam = para + s1;
            Console.WriteLine("Ürünün %18 Kdv'li fiyatı : " + toplam);
            Console.ReadLine();
        }
       
        private static void SayiToplamı()
        {
            Console.Write("Bir sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < n; i++)
            {
                toplam += i;
            }
            Console.WriteLine("1'den " + n + " sayısına kadar olan sayıların toplamı = " + toplam);

            Console.ReadLine();
        }
        private static void PolidronSayi()
        {
            int a, b, toplam = 0, sayi;
            Console.Write("Bir sayı giriniz:");
            a = int.Parse(Console.ReadLine());
            sayi = a;
            while (a > 0)
            {
                b = a % 10;
                toplam = (toplam * 10) + b;
                a = a / 10;
            }
            if (sayi == toplam)
                Console.Write("Girdiğiniz sayı palindrom bir sayıdır.");
            else
                Console.Write("Girdiğiniz sayı palindrom bir sayı değildir.");
            Console.ReadLine();
        }

        private static void DikdörtgenAlan()
        {
            int ukenar = 0, kkenar = 0;
            Console.Write("Diktörgenin uzun kenarını giriniz:");
            ukenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diktörgenin kısa kenarını giriniz:");
            kkenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çevre= {0}", ((ukenar + kkenar) * 2).ToString());
            Console.WriteLine("Alan= {0}", (ukenar * kkenar).ToString());
            Console.ReadKey();
        }


        private static void EnBüyükVeEnKücük()
        {
            int s1, s2, s3, buyuk, kucuk;

            Console.Write("Bir sayı girin");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı girin");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı girin");
            s3 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2 && s1 > s3)
                buyuk = s1;
            else if (s2 > s3)
                buyuk = s2;
            else
                buyuk = s3;

            if (s1 < s2 && s1 < s3)
                kucuk = s1;
            else if (s2 < s3)
                kucuk = s2;
            else
                kucuk = s3;

            Console.WriteLine("en büyük ile en küçük toplamı={0}", kucuk + buyuk);
            Console.ReadLine();
        }
        private static void İkiTamSayıToplamı()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam: " + (s1 + s2));
            Console.ReadLine();
        }
        private static void OrtalamaHesaplama()
        {
            double sayi1, sayi2, sayi3, toplam, ort;
            Console.Write("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz:");
            sayi3 = Convert.ToDouble(Console.ReadLine());
            toplam = sayi1 + sayi2 + sayi3;
            ort = toplam / 3;

            Console.WriteLine("Sayıların Toplamı:" + toplam);
            Console.WriteLine("Sayıların Ortalaması:" + ort);
            Console.ReadKey();
        }

        private static void ÜçteİkisininToplamı()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            int ss1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            int ss2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç : " + ((ss1 * 3 / 2) + (ss2 * 3 / 2)));

            Console.ReadLine();
        }

        private static void MatrisSayi()
        {

            int[,] a;
            a = new int[3, 3];
            int i, j;
            int r = 0, q = 0;

            Console.WriteLine("9 adet tamsayı girin");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j)
                    {
                        r += a[i, j];
                    }
                    if (i + j == 2)
                    {
                        q += a[i, j];
                    }
                }
            }
            Console.WriteLine("Düz köşegen Toplamı = {0}\nTers Köşegen Toplamı ={1}", r, q);
            Console.ReadKey();
        }
        private static void MtvOdemesi()
        {
            double tutar = 0;
            int sec1, sec2, sec3;
            Console.WriteLine("Araç Türü : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - Binek Araç");
            Console.WriteLine("(2) - Ticari Araç");
            Console.Write("Seçim Yapın (1)-(2) : ");
            sec1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Araç Yaşı : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - 1-3 Yaş");
            Console.WriteLine("(2) - 4-7 Yaş");
            Console.WriteLine("(3) - 7 Yaş Üzeri");
            Console.Write("Seçim Yapın (1)-(2)-(3) : ");
            sec2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Motor Hacmi : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - 0-1300");
            Console.WriteLine("(2) - 1300-1600");
            Console.WriteLine("(3) - 1600-2000");
            Console.WriteLine("(4) - 2000 Üzeri");
            Console.Write("Seçim Yapın (1)-(2)-(3) : ");
            sec3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (sec1 == 1)
            {
                tutar = 200;
            }
            else if (sec1 == 2)
            {
                tutar = 300;
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                tutar = 0;
            }

            if (sec2 == 1)
            {
                tutar = tutar * 1.75;
            }
            else if (sec2 == 2)
            {
                tutar = tutar * 1.5;
            }
            else if (sec2 == 3)
            {
                tutar = tutar * 1.25;
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                tutar = 0;
            }

            if (sec3 == 1)
            {
                tutar *= 2;
            }
            else if (sec3 == 2)
            {
                tutar *= 3;
            }
            else if (sec3 == 3)
            {
                tutar *= 4;
            }
            else if (sec3 == 4)
            {
                tutar *= 5;
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                tutar = 0;
            }


            Console.WriteLine("Ödenecek Tutar : {0}", tutar);
            Console.ReadKey();
        }

    }
}

using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace _14_MethodKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk Satır");
            MethodIsmi();
            Console.WriteLine("Son Satır");

            Merhaba("Aykut");
            //Merhaba2(37);
            Yasiniz("Aykut", 38);
            Yasiniz(yas: 33, adiSoyadi: "Hasan");


            Yasiniz2();
            Yasiniz2("Göksu");
            Yasiniz2("Göksu", 27);

            Yasiniz3("Batuhan", null);

            int toplam = Topla(10, 30);
            Console.WriteLine("Toplam = " + toplam);
            Console.WriteLine("Toplam = " + Topla(25, 5));

            Console.WriteLine("İşlem Sonucu = " + IslemYap(40, 20, "topla"));

            Console.Clear();
            string result = "";

            if (OndanBuyukMu(9, out result) == true)
            {
                Console.WriteLine("Sayı 10dan büyük");
            }

            else
            {
                Console.WriteLine("Sayı 10dan küçüktür");
            }


            Console.Clear();
            int sayiDegeri = 0;
            if (SayiMi("abc", out sayiDegeri))
            {
                Console.WriteLine("Girilen değer sayıdır " + sayiDegeri);
            }
            else
            {
                Console.WriteLine("Girilen değer sayı değildir ");
            }
        }

        //static keyword (anahtar sözcüğü) = erişim belirleyici
        //Geriye değer döndürmeyen, parametre almayan sadece kod bloğu içindeki satırları çalıştıran methos.

        static void MethodIsmi()
        {
            //kod bloğu iki süslü parantez arası
            Console.WriteLine("Hello, World");
        }

        //geriye değer döndürmeyen, tek parametre alan method
        static void Merhaba(string adiSoyadi)
        {
            Console.WriteLine("Merhaba " + adiSoyadi);
            Merhaba2(36);
        }

        static void Merhaba2(int yas)
        {
            Console.WriteLine(yas);
        }

        //geriye değer döndürmeyen, iki parametre alan method
        static void Yasiniz(string adiSoyadi, int yas)
        {
            Console.WriteLine(adiSoyadi + " " + yas + "yaşındadır.");
        }

        //geriye değer döndürmeyen, default değerlere sahip parametre tanımı olan method
        static void Yasiniz2(string adiSoyadi = "Ahmet", int yas = 18)
        {
            Console.WriteLine(adiSoyadi + " " + yas + " yaşındadır.");
        }
        //geriye değer döndürmeyen, nullable parametre barındıran method
        static void Yasiniz3(string adiSoyadi, int? yas)
        {
            Console.WriteLine(adiSoyadi + " " + yas + " yaşındadır.");
        }

        //geriye int tipinde değer döndüren ve iki tane parametre alan method
        static int Topla(int sayi1, int sayi2)
        {
            //int sonuc = sayi1 + sayi2;
            //return sonuc;

            return sayi1 + sayi2;
        }

        static double IslemYap(double sayi1, double sayi2, string islemTipi)
        {
            if (islemTipi == "topla")
            {
                return sayi1 + sayi2;
            }
            else if (islemTipi == "çıkar")
            {
                return sayi1 - sayi2;
            }
            else
            {
                return sayi1 + sayi2;
            }
            double sonuc = 0;

            if (islemTipi == "topla")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islemTipi == "çıkar")
            {
                sonuc = sayi1 - sayi2;
            }
            return sonuc;

        }

        //out keyword'u kullanılarak parametre tanımlama, geriye bool deger döndüren metod
        static bool OndanBuyukMu(int sayi, out string sonuc)
        {
            if (sayi > 10)
            {
                sonuc = "Sayı 10dan büyüktür";
                return true;
            }
            else
            {
                sonuc = "Sayı 10dan küçüktür";
                return false;
            }
        }

        //Method Overload
        static int Topla(int sayi1)
        {
            return 0;
        }
        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return 0;
        }
        static int Topla(decimal sayi1)
        {
            return 0;
        }
        static int Topla(decimal? sayi1)
        {
            return 0;
        }

        //SayiMi metodunun yazilması. int.TryParse metodun yerine kullanmak üzere yapılıyor
        //Method string bir değerin sayı olup olmadığını kontrol edecek
        //Sayı ise geriye true değer döndürecek ve aynı zamanda dönüştürdüğü sayıyı dışarı atacak.
        //Sayı değil ise geriye false değer döndürecek ve dışarıya sıfır değerini atacak

        static bool SayiMi(string deger, out int donusturulenSayi) // geriye değer döndürebilmek için bool yazdık
        {
            donusturulenSayi = 0;
            if (int.TryParse(deger, out donusturulenSayi))
            {
                return true;
            }
            else
            {            
                return false;
            }
        }
        //Yani bir string değerinin sayı olup olmadığını kontrol etmektedir.
        //"deger": kontrol edilecek olan string değer "sayi": eğer "deger" bir sayı ise, bu değişkene sayı değeri atanır
        //"sayi" değişkeni başlangıçta 0 olarak atanır."deger" stringi "int.TryParse" metodu ile bir sayıya dönüştürülmeye çalışılır. Eğer dönüştürme işlemi başarılı olursa (yani "deger", bir sayıdır), "sayi" değişkenine dönüşen sayı atanır ve metot "true" değeri döner. Eğer dönüştürme işlemi başarısız olursa (yani "deger", bir sayı değildir), "sayi" değişkenine 0 atanır ve metot "false" değeri döner. Bu kodu çağırdığınızda, metot size "deger" stringinin bir sayı olup olmadığını kontrol eder ve sonucu "true" veya "false" olarak döndürür. Eğer "deger" bir sayı ise, "sayi" değişkenine dönüşen sayıyı atar.

        //static bool SayiMi(string deger, out int donusturulenSayi)
        //{
        //    try
        //    {
        //        donusturulenSayi = Convert.ToInt32(deger);              
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        donusturulenSayi = 0;
        //        return false;
        //    }


        //}
    }
}

namespace _04_MantiksalOperatorlerveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı adını giriniz : ");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz : ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "göksu")
            {
                Console.WriteLine("Kullanıcı adı doğru");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı hatalı");
            }
            if (kullaniciAdi != "göksu")
            {
                Console.WriteLine("Kullanıcı adı hatalı");
            }

            // if(kullaniciAdi== "göksu")
            //     Console.WriteLine("Kullanıcı adı doğru");
            // else
            //     Console.WriteLine("Kullanıcı adı hatalı");

            //if(sifre== "123")
            //     Console.WriteLine("Şifre doğru");
            // else
            //     Console.WriteLine("Şifre hatalı");

            //if(kullaniciAdi == "göksu")
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");
            //    if (sifre == "123")
            //        Console.WriteLine("Şifre doğru");
            //    else 
            //        Console.WriteLine("Şifre yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}

            //if (kullaniciAdi == "göksu" && sifre == "123")
            //    Console.WriteLine("Giriş başarılı");
            //else Console.WriteLine("Kullanıcı adı veya şifre hatalıdır");

            //&& İlk şartım sağlanmıyorsa, ikincisine bakmıyor
            //& ilk şartım sağlanmıyorsa ikinci şarta da bakıyor.

            //if (kullaniciAdi != "göksu" || sifre != "123") 
            //    Console.WriteLine("Kullanıcı adı veya şifresi hatalı");
            //else
            //    Console.WriteLine("Giriş yaptınız");



            //Console.WriteLine("Devam etmek istiyor musunuz?");
            //string degisken1 = Console.ReadLine();
            //if (degisken1 == "E" || degisken1 == "e")
            //{
            //    Console.WriteLine("Evet");
            //}
            //else
            //{
            //    Console.WriteLine("Hayır");
            //}





            //kullanıcıdan bir sayı girmesini isteyelim
            //negatif bir sayı girdi ise uyarı verip uygulamayı bitirelim 
            //ikinci sayıyıda negatif girdi ise uyarı verelim
            //pozitif sayı girdi ise iki sayının çarpımını yazdıralım

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 <= 0)
            //{
            //    Console.WriteLine("Negatif bir sayı girdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    if (sayi2 <= 0)
            //    {
            //        Console.WriteLine("Negatif bir sayı girdiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("İki sayının çarpımı : " + (sayi1 * sayi2));

            //    }
            //}

            //if (sayi1 > 0)
            //{
            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    if (sayi2 > 0)
            //    {
            //        Console.WriteLine("İki sayının çarpımı : " + (sayi1 * sayi2));
            //    }
            //    else
            //        Console.WriteLine("Negatif bir sayı girdiniz");
            //}
            //else { Console.WriteLine("Negatig bir sayı girdiniz"); }


            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //string sonuc = " ";
            //if (sayi1 % 2 == 0)
            //    sonuc += sayi1 + ",";
            //if (sayi2 % 2 == 0)
            //    sonuc += sayi2 + ",";
            //if(sayi3 % 2 == 0)
            //    sonuc += sayi3 + ",";
            //if(sayi4 % 2 == 0) 
            //    sonuc += sayi4 + ",";




            //if (sayi1 % 2 == 0)
            //    Console.Write($"{sayi1}");
            //if (sayi2 % 2 == 0)
            //    Console.Write($"{sayi2}");
            //if (sayi3 % 2 == 0)
            //    Console.Write($"{sayi3}");
            //if (sayi4 % 2 == 0)
            //    Console.Write($"{sayi4}");


            bool evliMi = false;
            if (evliMi == true)
            {
                Console.WriteLine("Evli");
            }
            if (evliMi == false)
            {
                Console.WriteLine("Evli Değil");
            }
            if (evliMi != true)
            {
                Console.WriteLine("Evli Değil");
            }
            if (evliMi != false)
            {
                Console.WriteLine("Evli");
            }
            // if (evliMi == true)
            if (evliMi)
            {
                Console.WriteLine("Evli");
            }
            // if (evliMi == false)
            if (!evliMi)
            {
                Console.WriteLine("Evli Değil");
            }

            //ternary operator
            string sonuc = evliMi ? "Evli" : "Evli Değil";
            Console.WriteLine(sonuc);
            Console.WriteLine(evliMi ? "Evli" : "Evli Değil");


            int sayi1 = 40;
            Console.WriteLine(sayi1 <=0 ? "Negaitf Sayı" : "Pozitif sayı");

            //int kenarUzunlugu = 4;
            //Console.WriteLine(kenarUzunlugu <= 0 ? 0 : kenarUzunlugu*kenarUzunlugu);

            int kenarUzunlugu = 5;
            string alan = kenarUzunlugu <= 0 ? "Hatalı değer girdiniz" : (kenarUzunlugu*kenarUzunlugu).ToString();
            Console.WriteLine(alan);
        }

    }
}



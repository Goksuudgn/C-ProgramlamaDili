using System.Transactions;

namespace _07_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 0; i < 15; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //sonsuz döngü oluşur
            //for (int i = 5; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 20; i+=2)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 50; i >= 0; i -=3)
            //{
            //    Console.WriteLine(i);
            //}


            //for (char i = 'a'; i < 'z'; i++)
            //{
            //    Console.Write(i + " ");
            //}



            #region SORU
            //SORU : Başlangıç ve bitiş sayısı girilsin arasındaki çift sayılar yazılsın

            //Console.WriteLine("Başlangıç sayısını girin");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitiş sayısını girin");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //} 
            #endregion



            //if (sayi1 % 2 != 0)
            //    sayi1++;
            //for (int i = sayi1; i<= sayi2; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            #region SORU
            //SORU : Kullanıcıdan bir metin isteyelim Kaç kez yazdıracağımızı kullanıcıdan alalım

            //Console.WriteLine("Bir şehir giriniz");
            //string sehir = Console.ReadLine();

            //Console.WriteLine("Kaç kez yazılsın ?");
            //int tekrar = int.Parse(Console.ReadLine());

            //for (int i = 0; i < tekrar; i++)
            //{
            //    Console.WriteLine(sehir);
            //} 
            #endregion

            //for (int sayi = 1; sayi < 15; sayi++)
            //{
            //    for (char harf = 'A'; harf < 'K'; harf++)
            //    {
            //        Console.WriteLine($"Sayı = {sayi}--Harf = {harf}");
            //    }
            //}


            #region SORU
            //SORU : Çarpım tablosu

            for (int sayi = 1; sayi <= 10; sayi++)
            {
                for (int sayi2 = 1; sayi2 <= 10; sayi2++)
                {
                    Console.WriteLine($"{sayi} * {sayi2} = {sayi * sayi2}");
                }
            } 
            #endregion




            Console.ReadKey();
        }
    }
}

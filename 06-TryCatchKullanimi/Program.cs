﻿namespace _06_TryCatchKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				//hata alınma ihtimali olan kodları bu bloğun içerisine yazabiliriz
				//100 tane satır varsa ve 10. satırda hata alındı ise 10. satır ve sonrasındaki hiç bir satır çalışmaz
			}
			catch (Exception hata)
			{
				//hata alındığında çalışmasını istediğimiz kodları bu bloğa yazabiliriz				
			}
			finally 
			{
				//hata alınsada çalışmasını istediğimiz kodları bu bloğa yazabiliriz
			}

            //try
            //{
            //	Console.WriteLine("Birinci sayıyı giriniz");
            //	int sayi1 = Convert.ToInt32(Console.ReadLine());
            //	Console.WriteLine("İkinci sayıyı giriniz");
            //	int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception hata)
            //{

            //             Console.WriteLine("Hata Alındı");
            //             Console.WriteLine("Message = " + hata.Message);
            //             Console.WriteLine("InnerException = " + hata.InnerException);
            //             Console.WriteLine("StackTrace = " + hata.StackTrace);
            //         }

            //try
            //{
            //    Console.WriteLine("Birinci sayıyı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch {; }

            //try
            //{
            //    Console.WriteLine("Birinci sayıyı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İkinci sayıyı giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine("Hata Alındı");               
            //}
            //finally 
            //{ 
            //    Console.WriteLine("İşlem tamamlandı"); 
            //}

            //Console.ReadKey();

            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hata Alındı");
            }
            

            Console.ReadKey();
        }
    }
}

namespace _02_AritmetikselOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (+) Operatörü
            int toplam = 5 + 10 + (8 + 4);
            Console.WriteLine("Sonuç = " + toplam);


            decimal fiyat1 = 125.53M;
            decimal fiyat2 = 25.21M;

            decimal toplamFiyat = fiyat1 + fiyat2;
            Console.WriteLine("Toplam Ücret = " + toplamFiyat);
            Console.WriteLine($"Toplam Ücret = {toplamFiyat}"); //+ operatörü kullanılmadan metinsel değer birleştirilmesi
            Console.WriteLine(fiyat1 + fiyat2 + "Tl"); //işlem toplama
            Console.WriteLine("Tl" + fiyat1 + fiyat2);  //işlem birleştirme

            string adi = "Göksu ";
            string soyadi = "Doğan";
            Console.WriteLine(adi + soyadi);
            #endregion

            #region (-) Operatörü
            // Sayısal değerlerde toplama işlemi yapmak için kullanılır
            int sayi1 = 24;
            int sayi2 = 14;
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç = " + sonuc);
            Console.WriteLine("Sonuç = " + (sayi2 - sayi1));
            Console.WriteLine(((sayi2 - sayi1) + (50 + 20)) + "Sonuç");
            #endregion

            #region İkili Operatör Kullanımı
            int yas = 35;
            // yaşı 1 arttırmak için 
            yas++;
            Console.WriteLine("Sonuç = " + yas);
            ++yas;
            Console.WriteLine("Sonuç = " + yas);
            // yaşı 1 eksiltmak için 
            yas--;
            Console.WriteLine("Sonuç = " + yas);

            int sayi5 = 65;
            --sayi5;
            Console.WriteLine("Sonuç = " + sayi5);

            int sayi6 = 36;
            sayi6 += 10;
            Console.WriteLine("Sonuç = " + sayi6);
            sayi6 -= 10;
            Console.WriteLine("Sonuç = " + sayi6);


            sayi6 += 10; // sayi6= sayi6 + 10
            Console.WriteLine("Sonuç = " + sayi6);
            sayi6 -= 10; //sayi6 = sayi6 -10
            Console.WriteLine("Sonuç = " + sayi6);
            sayi6 *= 10; // sayi6 = sayi6 *10
            Console.WriteLine("Sonuç = " + sayi6);
            sayi6 /= 10;//sayi6 = sayi6 / 10 
            Console.WriteLine("Sonuç = " + sayi6);

            #endregion


            bool evlimi = false;
            Console.WriteLine("Evli Mi = " + evlimi);
            Console.WriteLine("Evli Mi = " + !evlimi);


            //Herhangi bir tuşa basılana dek console ekranı açık kalır
            Console.ReadKey();
        }
    }
}

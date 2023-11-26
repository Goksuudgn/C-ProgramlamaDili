namespace _03_TipDegistirmeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert sınıfı ile tip değiştirme 

            string sayi1 = "5";
            string sayi2 = "6";

            int toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
            Console.WriteLine($"Sonuç = {toplam}");
            Console.WriteLine($"Sonuç = {sayi1 + sayi2}");

            //int sonuc = Convert.ToInt32("78") - Convert.ToInt32("20");
            //int sonuc = Convert.ToInt32("78") - Convert.ToInt32(Convert.ToInt16(sayi1) + Convert.ToInt16(sayi2));

            char karakter = Convert.ToChar(sayi1);

            int birinciSayi = 8;
            int ikinciSayi = 9;
            //double sonuc = birincisayi / İkinciSayi; //int tipinde değerler olduğu için sonuç virgüllü olarak bize dönmez.
            double sonuc = Convert.ToDouble(birinciSayi) / Convert.ToDouble(ikinciSayi);
            Console.WriteLine($"Sonuç = {sonuc}");

            int a = 0;
            int b = 1;
            bool c = Convert.ToBoolean(a);
            bool d = Convert.ToBoolean(b);
            #endregion

            #region Parse metodu ile tip
            toplam = int.Parse(sayi1) + int.Parse(sayi2);
            Console.WriteLine("Sonuç = " + toplam);

            decimal virgulluSonuc = decimal.Parse(sayi1) / decimal.Parse(sayi2);
            Console.WriteLine("Sonuç = " + virgulluSonuc);

            //ArgumentNullException = değer null olduğu için hata fırlatır.
            //string? deger1 = null;
            //Convert.ToInt32(deger1);
            //int.Parse(deger1);
            //FormatException = değer uygun formatta olmadığı zaman bu hata fırlatılır.
            //Convert.ToInt32("5p");

            //OverFlowException = değer dönüştürülecek hedef türün sınırları dışında ise bu hata fırlatılır
            //Convert.ToIn16(9999999);


            // Convert ile Parse arasındaki Fark
            // 1- Convert sınıfı ile belirli tipleri dönüştürebiliriz  (int, decimal, datetime, double, double, bool, char, byte). ,ama parse metodunda tüm türler dönüştürülür.
            // 2- Convert sınıfında değerin null olması durumunda ArgumentNullException hatasına düşmez, fakat parse metodunda hataya düşer. 
            #endregion

            #region ToString metodu ile string tipine dönüştürme
            decimal x = 5;
            decimal y = 7;
            Console.WriteLine(x.ToString());
            Console.WriteLine(x.ToString() + y.ToString());

            decimal sonuc1 = x / y;
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc1.ToString("n2"));
            Console.WriteLine(123143.ToString("c2"));
            #endregion

            #region Implicit(üstü kapalı) ve Explicit(Belirgin) Dnüşümler

            //üstü kapalı
            int t = 135;
            long u = t;


            //belirgin
            long i = 123;
            int i2 = (int)i;



            #endregion


            Console.WriteLine("Lütfen adınızı giriniz...");
            string adi = Console.ReadLine();
            Console.WriteLine("Adınız : " + adi);


            #region Örnek 1

            Console.WriteLine("Lütfen birinci sayıyı giriniz...");
            int birinciSayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birinci sayı : " + birinciSayi1);
            Console.WriteLine("Lütfen ikinci sayıyı giriniz...");
            int ikinciSayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayı : " + ikinciSayi2);
            Console.WriteLine("Sayıların Toplamı : " + (birinciSayi1 + ikinciSayi2));
            #endregion


            #region Örnek 2
            Console.WriteLine("1. Sınav Notunu lGirin : ");
            int not1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sınav Notunu lGirin : ");
            int not2 = int.Parse(Console.ReadLine());

            //double notOrtalamasi = (not1 + not2)/2.0 ;
            double notOrtalamasi = (((double)not1 + ((double)not2)) / 2);

            Console.WriteLine("Not Ortalaması : " + notOrtalamasi.ToString("n2"));

            #endregion




            Console.ReadKey();



        }
    }
}

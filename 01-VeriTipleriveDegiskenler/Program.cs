namespace _01_VeriTipleriveDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 999;
            int sayi2 = 999;
            int sayi3, sayi4; //değerleri sıfırdır
            //sayi3 = 5;
            //sayi3 = 45;

            decimal virgulluSayi = 2.5M;
            decimal virgulluSayi2 = 2205;
            //decimal virgulluSayi = 2.5M;

            float virgulluSayi3 = 1.5F;
            float virgulluSayi4 = 1;
            //float virgulluSayi2 = 1.53f;

            double virgulluSayi5 = 5.5D;
            //double virgulluSayi3 = 5.5d;
            //double virgullusayi3 = 5.5;

            short kucukSayi1 = 23;

            string metin;
            metin = string.Empty; //(İçerisi boş) nullda bir değer yok emptyde boş değeri var
            string metin1 = "aasad45sf465f6";
            string metin2 = "12345";
            string metin3 = "satır1\nsatır2\nsatır3";


            char karakter1 = 'A';
            char karakter2 = '0';
            char karakter3 = ' ';
            char karakter4 = '*';


            bool evet = true;
            bool hayır = false;


            object degisken1; // şu an objecti tipi yok
            degisken1 = "assad";          //değişken atanınca atanan değişkenin tipi olarak varsayılır 
            degisken1 = 123456;

            int? nullSayi1 = null;
            bool? nullBool1 = null;
            string? nullString = null;

            DateTime? nullDateTime = null;

            DateTime dateTime1 = DateTime.Today;
            DateTime dateTime2 = DateTime.Now;

            Console.WriteLine(dateTime2 + " " + dateTime1);
            Console.WriteLine(metin3);
            Console.WriteLine("Hello, World!");

            //Örnek Soru:

            //Adı soyadı
            string adiSoyadi = "Göksu Doğan";
            //Tc Kimlik no
            long tcKimlikNo = 11111111111; //Kullanılmalı
            ulong tcKimlikNo1 = 11111111111;
            string tcKimlikNo2 = "111111111111";
            //Telefon
            ulong telephoneNumber = 5454958546;
            string telefonNo = "05364895846";
            //Email
            string email = "goksuudogan@gmail.com";
            //Yaş(Boş geçilebilir)
            ushort? yas = 26;
            //Doğum Tarihi (Boş geçilebilir)
            DateTime? dogumTarihi = DateTime.Now;
            //Evli mi ?
            bool evliMi = false;




        }
    }
}

namespace _15_StringMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trim() metodu string değerin başındaki ve sonundaki boşluk karakterini kaldırır
            string _adiSoyadi = "  Göksu Doğan  ";
            string adiSoyadi1 = _adiSoyadi.Trim();
            string adiSoyadi2 = _adiSoyadi.TrimEnd(); //sadece sondaki boşluğu siler
            string adiSoyadi3 = _adiSoyadi.TrimStart(); // sadece baştaki boşluğu siler
            Console.WriteLine(adiSoyadi1);

            //ToLower() tüm harfleri küçük harfe dönüştürür
            string _isim = "GökSu DoĞan";
            string isim1 = _isim.ToLower();
            Console.WriteLine(isim1);


            //ToUpper() tüm harfleri büyük harfe dönüştürür
            string isim2 = _isim.ToUpper();
            Console.WriteLine(isim2);

            //Replace() metnin içindeki herhangi bir değeri farklı bir değer ile değiştirmek için 
            string _aciklama = "metnin içindeki herhangi bir değeri farklı bir değer";
            string aciklama1 = _aciklama.Replace('i', 'İ');
            string aciklama2 = _aciklama.Replace(' ', '-');
            string aciklama3 = _aciklama.Replace(" ", "");
            string aciklama4 = _aciklama.Replace("a", "");
            string aciklama5 = _aciklama.Replace("bir", "iki");

            //ToCharArray() metnin içindeki tüm karakterleri char dizisine dönüştürerek geriye döner 
            string ilce = "Gaziosmanpaşa";
            char[] karakterler1 = ilce.ToCharArray();
            char[] karakterler2 = ilce.ToCharArray(3,2);

            Console.Clear();
            Console.WriteLine(karakterler1);
            Console.WriteLine("------------");
            Console.WriteLine(karakterler2);


            //PadLEft() : Metnin istediğimiz karakter sayısına gelene kadar sol kısmına değer ekliyor 

            string _faturaNo = "41";
            string faturaNo1 = _faturaNo.PadLeft(5, '0'); //Kaç elemanlı yapmak istiyorum 5 ve hepsini 0 eklemek istiyorum 
             Console.WriteLine(faturaNo1);


            //PadRight() :  Metnin istediğimiz karakter sayısına gelene kadar sağ kısmına değer ekliyor 

            string faturaNo2 = _faturaNo.PadRight(4, '0');
            Console.WriteLine(faturaNo2);
        }
    }
}

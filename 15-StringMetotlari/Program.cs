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
            char[] karakterler2 = ilce.ToCharArray(3, 2);

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

            //Equals() parametre olarak verilen değer ile değişkenin değeri aynı mı değil mi diye kontrol eder
            string _metin = "kıyaslamak için kullanılır";
            bool esitMi1 = _metin.Equals(" için");
            bool esitMi2 = _metin.Equals("kıyaslamak için kullanılır");

            //aynısını

            if (_metin == "kıyaslamak için kullanılır")
                esitMi1 = true;
            else
                esitMi1 = false;

            //SubString() metodu string bir değer içerisinden parça almak için kullanılır
            string _ornek = "Örnek metrni buraya giriyorum";
            string ornek1 = _ornek.Substring(5); //5. karakterden sonraki hepsinin yazdırır
            string ornek2 = _ornek.Substring(5, 4); //5. karakterden sonra 4 karakter yazdırıyor

            //Reverse () metodu metnin içindeki karakterleri bir dizi haline getirerek tersten sıralar 

            string _terstenMetin = "Göksu DOĞAN";
            char[] metinDizi = _terstenMetin.Reverse().ToArray();
            string terstenMetin = "";
            foreach (var item in metinDizi)
            {
                terstenMetin += item.ToString();
            }
            Console.WriteLine(terstenMetin);

            //IndexOf() metodu metnin içindeki bir karakterin ya da kelimenin kaçıncı indexte olduğunu bize geriye döner
            string notebook = "Asus Zenbook";
            int index1 = notebook.IndexOf('o');
            int index2 = notebook.IndexOf("Zen");
            int index3 = notebook.IndexOf("zen"); // Büyük küçük harf duyarlılığından dolayı bunu kabul etmedi


            //Remove() metodu metnin içindeki herhangi bir indexten itibaren karakterleri silmek için kullanılır. Metnin içerisinden parça silmek için
            string _mevsim = "Ağustos";
            string mevsim1 = _mevsim.Remove(3);
            string mevsim2 = _mevsim.Remove(3, 2);
            //string mevsim3 = _mevsim.Remove(3, 5); //eğer olmayan bir index numarası verilirse kod satırı hata verir
            //string mevsim3 = _mevsim.Remove(13, 5); // eğer olmayan bir index numarası verilirse kod satırı hata verir


            // Contains() metodu metnin içinden bir karakteri ya da kelimeyi içeriyor mu dişye kontrol etmek için kullanılır
            string marka = "philips";
            bool içeriyorMu1 = marka.Contains('i');
            bool içeriyorMu2 = marka.Contains("lip");
            bool içeriyorMu3 = marka.Contains("olip");
            bool içeriyorMu4 = marka.Contains('o');
            bool içeriyorMu5 = marka.Contains('İ');
            bool içeriyorMu6 = marka.Contains("LİP");  //Büyük küçük harf duyarlılığı var 

            //Split()  metodu metnin içindeki bir karakterden itibaren tüm metni parçalayarak bir string dizisi haline dönüştürür
            string gunler = "Pazartesi;Salı;Çarşamba;Perşembe;Cuma;Cumartesi;Pazar";
            string[] gunlerDizisi = gunler.Split(';');
            foreach (var item in gunlerDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****************");

            string gunler2 = "Pazartesi--Salı--Çarşamba--Perşembe--Cuma--Cumartesi--Pazar";
            string[] gunlerDizisi2 = gunler2.Split("--");
            foreach (var item in gunlerDizisi2)
            {
                Console.WriteLine(item);
            }


            //StartWith() metodu metnin herhangi bir karakter ya da kelime ile başlayıp başlamadığını kontrol ediyor
            string meyve = "Portakal";
            bool ileBaslıyorMu1 = meyve.StartsWith('p');
            bool ileBaslıyorMu2 = meyve.StartsWith('P');
            bool ileBaslıyorMu3 = meyve.StartsWith('x');

            bool ileBaslıyorMu4 = meyve.StartsWith("Por");
            bool ileBaslıyorMu5 = meyve.StartsWith("por");


            //EndsWith() metodu metnin herhangi bir karakter ya da kelime ile bitip bitmediğini kontrol ediyor

            bool ileBitiyorMu1 = meyve.EndsWith('l');
            bool ileBitiyorMu2 = meyve.EndsWith('L');
            bool ileBitiyorMu3 = meyve.EndsWith('x');

            bool ileBitiyorMu4 = meyve.EndsWith("Kal");
            bool ileBitiyorMu5 = meyve.EndsWith("kal");

            Console.Clear();

            //IsNullOrEmpty() metodu metnin NULL veya boş olup olmadığını kontrol eder. Null veya boş ise True değil ise False değeri geriye döndürür
            //string isim ="";
            //string? isim = null;
            //isim = "Göksu";

            //if (string.IsNullOrEmpty(isim) == true)
            //    Console.WriteLine("İsim girmediniz");
            //else
            //    Console.WriteLine("Merhaba " + isim);

            //kullanıcıdan 3 tane isim istesin isim girmediyse isim girmediniz uyarısını versin tekrar girmesini sağlasın, 3 ismi girdikten sonra M harfi ile başlayanları alt alta ekrana yazdırsın
            // Kullanıcıdan 3 isim iste
            string[] isimler = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Lütfen {i + 1}. ismi girin: ");
                string isim = Console.ReadLine();

                // Girilen isim boş ise uyarı ver ve tekrar giriş iste
                while (string.IsNullOrEmpty(isim))
                {
                    Console.WriteLine("İsim girmediniz. Lütfen tekrar deneyin.");
                    Console.Write($"Lütfen {i + 1}. ismi girin: ");
                    isim = Console.ReadLine();
                }

                isimler[i] = isim;
            }

            // M harfi ile başlayanları alt alta yazdır
            Console.WriteLine("M harfi ile başlayan isimler:");
            foreach (string isim in isimler)
            {
                if (isim.StartsWith("M") || isim.StartsWith("m"))
                {
                    Console.WriteLine(isim);
                }
            }
        }
    }
    }
    
            
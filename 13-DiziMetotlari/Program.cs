using System.Collections;

namespace _13_DiziMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetValue() metodu ile dizinin içindeki değerini almak istediğimiz index verisi ile elemana erişmek için kullanılır.

            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs" };
            string ay1 = aylar[0];
            string ay2 = aylar.GetValue(0).ToString();
            object ay3 = aylar.GetValue(0);


            int[] intDizisi = { 40, 50, 60, 70 };
            int deger1 = Convert.ToInt32(intDizisi.GetValue(2));
            string deger2 = intDizisi.GetValue(2).ToString();



            //SetValue() elimizdeki bir indexe istinaden dizinin elemanına değer ataması yapmak için kullanılır

            aylar.SetValue("Aralık", 4);


            // Array.IndexOf() Metodu dizinin içindeki bir elemanın index numarasını almak için kullanılır
            // ÖNEMLİ NOT: eğer aramak istediğimiz değer dizinin içerisinde birden fazla ise ilk elemanın indeksine döner 

            int indexNo = Array.IndexOf(aylar, "Mart");


            //Dizinin içerisinde kaç tane eleman olduğunu döner
            int elemanSayisi = aylar.Length;

            //Array.Sort() metodu ile dizinin içindeki elemanları sıralayabiliriz
            //eğer elemanlar sayısal bir değere sahipse küçükten büyüğe doğru sıralama yapar 
            //eğer string bir değer ise A'dan Z'ye doğru sıralama yapar.

            Console.WriteLine("Normal hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }

            Array.Sort(aylar);
            Console.WriteLine("Sort metodu ile sıralanmış hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }

            int[] sayilar = { 1, 6, 4, 3, 9, 0 };
            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            // Array.Reverse() metodu büyükten küçüğe Z'den A'ya sıralamada kullanılır. Yani tersten sıralama
            //Kullanılırken önce sort metodu kullanılmalıdır.

            Array.Sort(sayilar);
            Array.Reverse(sayilar);


            //Array.Clear() metodu ile dizi içindeki elemanları silebiliriz.
            //ÖNEMLİ NOT : Silmek eleman sayısını silmek değil, silme yaptığınızda eleman sayısı aynı şekilde kalaır sadece değerleri silinir. yani null atanır

            int[] sayilar2 = { 1, 6, 4, 3, 9, 0 };
            //Array.Clear(sayilar2);

            Array.Clear(sayilar2, 3, 2); // 3, elemandan itibaren 2 tane 

            Console.Clear();
            //Clone() metodu bir dizinin aynısından bir tane daha kopyasını oluşturur
            string[] renkler = { "Kırmızı", "Beyaz", "Yeşil", "Mor" };
            string[] renklerKlon = (string[])renkler.Clone();
            foreach (string renk in renklerKlon)
            {
                Console.WriteLine(renk);
            }

            Console.Clear();
            //Array.Copy()
            string[] renklerYeni = new string[renkler.Length]; //Üstteki dizinin aynı boyutunda oluştursun
            Array.Copy(renkler, 1, renklerYeni, 0, 2); //renkler dizisindeki 1. indexi renklerYenideki 0dan başlayarak 2 tane kopyala
            foreach (string item in renkler)
            {
                int index = Array.IndexOf(renkler, item);
                Console.WriteLine(index + ".Eleman = " + item);
            }

            Console.WriteLine("------------------");

            foreach (string item in renklerYeni)
            {

                int index = Array.IndexOf(renklerYeni, item);
                Console.WriteLine(index + ".Eleman = " + item);
            }

            Console.WriteLine("----------- Sıralı");
            Array.Sort(renklerYeni);
            foreach (string item in renklerYeni)
            {

                int index = Array.IndexOf(renklerYeni, item);
                Console.WriteLine(index + ".Eleman = " + item);
            }


            //Array.Resize() : Boyutunu değiştirmek için kullanıllır. Mesela elemanlı bir dizinin eleman sayısını  yapmak için kullanılır

            Console.Clear();
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba" };
            foreach (string gun in gunler)
            {
                Console.WriteLine(gun);
            }
            Console.WriteLine("---------------");
            Array.Resize(ref gunler, 5); //ref ile kullanılmalı. gunler dizisinin eleman sayısı 5 olsun demektir.
            gunler[4] = "Cuma";
            foreach (string gun in gunler)
            {
                Console.WriteLine(gun);
            }

            Console.Clear();
            // ArrayList : Bir sınıftır. Dinamik olarak büyüyüp küçülebilen, farklı değişken tiplerinde değerleri saklayabilen koleksiyon tabanlı bir sınıftır.
            //Diziler ile arrayList arasındakş farklar
            //1-Dizi oluştururken boyutu yani kaç elemanlı olacağı belirtilmeli ama burda biz ekledikçe kendiliğinden  oluşur
            //2-Dizilerin türü(veri tipi) oluşturulurken belirtilir yani string[] ya da int[] gibi ama burada farklı türde değerler atabiliyoruz.

            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(2);
            //arrayList.Add("elma");
            rakamlar[2] = 1;   //2 index numarası
                                //arrayList[1] = "Ahmet";    //1 index numarası
            rakamlar.Sort(); // a'dan z'ye ya da küçükten büyüğe sıralama yapar
            rakamlar.Reverse(); //tersten sıralama yapar.!!! Sorrt olmadan çalışmaz!!!
            rakamlar.Remove(7); // 7 elamanını kaldırır index numarasını değil!!!
            rakamlar.RemoveAt(0); // index numarası ile elemanı siler 0. indexteki elemanı yani siler

            Console.WriteLine("Eleman sayısı = " + rakamlar.Count); //Count bir propertydir. Eleman sayısını gösterir.
            rakamlar.Clear(); // tamamen siliyor 
            Console.WriteLine("Eleman sayısı = " + rakamlar.Count);

            foreach (var array in rakamlar)
            {
                Console.WriteLine(array);
            }




        }
    }
}

namespace _11_DiziKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dizinin eleman sayısını belirterek içi boş olacak şekilde oluşturulur.
            int[] rakamlar = new int[5];

            //Dizinin bir elemanına değer yazma
            rakamlar[0] = 1;
            rakamlar[1] = 2;
            rakamlar[2] = 3;
            rakamlar[3] = 4;
            rakamlar[4] = 5;

            Console.WriteLine(rakamlar[0]); 
            
            string[] isimler = new string[3];

            isimler[0] = "Göksu";
            isimler[1] = "Batuhan";
            isimler[2] = "Kaan";

            Console.WriteLine(isimler[1]);

            //Dizinin hem eleman sayısını vererek hem de elemanlarına değer ataması yaparak dizi oluşturma

            string[] arabalar = new string[3] { "Volvo" , "Bmw", "Ford"};
            Console.WriteLine(arabalar[1]);


            //Dizinin eleman sayısını belirtmeden, değer ataması yaparak eleman sayısı ve değerlerini oluşturma
            string[] renkler = new string[] { "Kırmızı", "Beyaz" };
            string[] renkler2 = { "Kırmızı", "Beyaz" };

            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);
            }




        }
    }
}

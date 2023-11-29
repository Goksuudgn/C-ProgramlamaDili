namespace _10_Break_Continue_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Break : Döngünün içerisinden çıkmak istediğiniz zaman kullanılır 
            //for(int i = 0; i < 5; i++) 
            //{
            //    Console.WriteLine(i);

            //    if (i == 3)
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("Bitti");

            //// Burda 3ü de yazdırıp break komutunu görüyor

            //for (int i = 0; i < 5; i++)
            //{


            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("Bitti");

            ////burada 3e kadar yazdırıp break komutunu görüyor

            //int a = 0;
            //while (a < 20)
            //{
            //    if (a == 10)
            //        break;
            //    Console.WriteLine(a);
            //    a++;
            //}

            ////continue = döngüde bir sonraki adıma geçmek için kullanılır.

            //for (int i = 0; i < 10;  i++)
            //{
            //    if (i == 5 || i == 8)
            //        continue; ;
            //    Console.WriteLine(i);
            //    Console.WriteLine("Merhaba");
            //}


            int a = 0;
            while (a < 15)
            {
                if (a == 5)
                {
                    a++;
                    continue;
                }
                Console.WriteLine(a);
                a++;
            }



        }


    }
}

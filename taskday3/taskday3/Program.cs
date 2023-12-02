namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //əgər bu iki ədədin cəmi cüt ədədirsə "Cəm cüt ədəddir"
            // deyilsə "Cəm tək ədəddir" yazı ekrana yazdırmaq
            Console.WriteLine("Task 1");
            Console.Write("Ilk ededi daxil edin: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;

            if (c % 2 == 0)
            {
                Console.WriteLine("Cem cut ededdir");
            }

            else
            {
                Console.WriteLine("Cem tek ededdir");
            }

            Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");


            Console.WriteLine("Task 2 ");
            int[] a1 = { 11, 14, 18, 23, 24, 28, 33, 35, 39, 40 };
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] % 2 == 0)
                {
                    Console.WriteLine(a1[i]);
                }
            }

            Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");
            Console.WriteLine("Task 3 ");
            Console.WriteLine("Tek olanlar: ");
            int sum = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                if ((a1[i] % 2) != 0)
                {

                    Console.WriteLine(a1[i]);
                    sum += a1[1];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Cemleri: ");
            Console.WriteLine(sum);
            Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");

            Console.WriteLine("Task 4 ");
            Console.WriteLine(" 4 reqemli eded daxil edin:");




            int eded = Convert.ToInt32(Console.ReadLine());


            if ((eded >= 1000) && (eded <= 9999))
            {


                int cem = 0;

                while (eded != 0) // eded 0a beraber olmadiqca hemin eded 10a bolunecek ve qaliq tapilacaq
                {
                    cem += eded % 10;
                    eded /= 10;
                }

                Console.WriteLine("Ededin reqemlerinin cemi: " + cem);

            }

            Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" "); //Ay muellim bu ne task idi  aglayacam gece saat 2di


            Console.WriteLine("Task 5");


            Telebe telebe1 = new Telebe { Ad = "Metin", Soyad = "Vahid", Yas = 15, ixtisas = "Biznesin Idareedilmesi", QrupunNomresi = 685 };
            Telebe telebe2 = new Telebe { Ad = "Yaqub", Soyad = "Ehmedov", Yas = 55, ixtisas = "Informasiya texnologiyalari", QrupunNomresi = 563 };

            Telebe[] telebe3 = new Telebe[] { telebe1, telebe2 };
            Console.WriteLine(telebe3[0].Ad); Console.WriteLine(telebe3[0].Soyad); Console.WriteLine(telebe3[0].Yas); Console.WriteLine(telebe3[0].ixtisas); Console.WriteLine(telebe3[0].QrupunNomresi);
            Console.WriteLine(" ");
            Console.WriteLine(telebe3[1].Ad); Console.WriteLine(telebe3[1].Soyad); Console.WriteLine(telebe3[1].Yas); Console.WriteLine(telebe3[1].ixtisas); Console.WriteLine(telebe3[1].QrupunNomresi);







            Console.ReadKey();
        }


        public class Telebe
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
            public string ixtisas { get; set; }
            public int QrupunNomresi { get; set; }




        }

    }
}
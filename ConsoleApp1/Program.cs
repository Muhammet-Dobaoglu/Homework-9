namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kelime = new string[] { "H","A","V", "B","C","D","E","F","R","T","U","I","P","L","G","N" };

            int n;
            int sayi = 0;
            Console.WriteLine("Bir N sayısı giriniz…");
            n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= (n-1); i++)
            {
                for (int j = 1; j <= (n-i); j++)
                {
                    Console.Write("");
                }

                for (int k = 1; k <= (2 * i + 1); k++)
                {
                    if (sayi == 16)
                    {
                        sayi -= 16;
                        Console.Write(kelime[sayi]);
                        sayi += 1;
                    }
                    else
                    {
                        Console.Write(kelime[sayi]);
                        sayi += 1;
                    }

                }

                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
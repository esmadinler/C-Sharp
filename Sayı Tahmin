namespace SayıTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rastgele = random.Next(1, 50);
            int tahmin;
            int sayac = 0;
 
            do
            {
                Console.Write("Bir sayi giriniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin > rastgele)
                {
                    Console.WriteLine("Sayıyı küçültün.");
                }
                else if (tahmin < rastgele)
                {
                    Console.WriteLine("Sayıyı büyültün.");
                }
                sayac++;
                
            } 
            while (tahmin != rastgele);
            Console.WriteLine("TEBRİKLER " + sayac + ". denemede sayıyı buldunuz !!");
 
            Console.ReadLine();
        }
    }
}

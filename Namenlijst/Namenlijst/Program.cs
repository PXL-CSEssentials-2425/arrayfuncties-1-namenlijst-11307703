namespace Namenlijst
{
    internal class Program
    {
        private static string[] namen = new string[4];
        static void Main(string[] args)
        {
            Console.WriteLine("===Namen afdrukken===");
            Console.WriteLine();

            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write($"Naam {i+1} :  ");
                namen[i] = Console.ReadLine();
            }
                Array.Sort(namen);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===Namen afgedrukt gesorteerd===");
            for (int i = 0;i < namen.Length; i++) 
            {
                
                Console.WriteLine($"Naam {i+1} : {namen[i]}");
                
            }

            Console.ReadKey(true);
        }
    }
}

namespace _01_CI_CD_Pipes_Uebung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe bitte deine erste Zahl ein, welche du addieren möchtest!");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gebe bitte deine zweite Zahl ein, welche du addieren möchtest!");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            int sum = zahl1 + zahl2;

            Thread.Sleep(500);
            Console.WriteLine("Aufnahme beider Zahlen... \n" );

            Thread.Sleep(1000);
            Console.WriteLine("Berechnung beider Zahlen... \n");

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Das Ergbnis ist: " + sum + "\n");
        }
    }
}

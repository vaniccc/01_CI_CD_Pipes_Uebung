namespace _01_CI_CD_Pipes_Uebung
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hallo! Welche Berechnung möchtest du durchführen? Bitte wähle eine Zahl von 1 bis 4 (1 = Addition, 2 = Subtraktion, 3 = Multiplikation, 4 = Division).");
            int selectedCalculation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe bitte deine erste Zahl ein, welche du berechnen möchtest:");
            int enteredNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe bitte deine zweite Zahl ein, welche du berechnen möchtest:");
            int enteredNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Thread.Sleep(1000);
            Console.WriteLine("Aufnahme beider Zahlen... \n");

            Thread.Sleep(1000);
            Console.WriteLine("Berechnung beider Zahlen... \n");

            int result = 0;

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Yellow;

            try
            {
                switch (selectedCalculation)
                {
                    case 1:
                        result = Rechner.Addiere(enteredNumber1, enteredNumber2);
                        Console.WriteLine($"Das Ergebnis deiner Addition ({enteredNumber1} + {enteredNumber2}) ist: {result}");
                        break;
                    case 2:
                        result = Rechner.Subtrahiere(enteredNumber1, enteredNumber2);
                        Console.WriteLine($"Das Ergebnis deiner Subtraktion ({enteredNumber1} - {enteredNumber2}) ist: {result}");
                        break;
                    case 3:
                        result = Rechner.Multipliziere(enteredNumber1, enteredNumber2);
                        Console.WriteLine($"Das Ergebnis deiner Multiplikation ({enteredNumber1} * {enteredNumber2}) ist: {result}");
                        break;
                    case 4:
                        result = Rechner.Dividiere(enteredNumber1, enteredNumber2);
                        Console.WriteLine($"Das Ergebnis deiner Division ({enteredNumber1} / {enteredNumber2}) ist: {result}");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe! Bitte gebe eine Zahl von 1 bis 4 ein.");
                        Console.ResetColor();
                        return;
                }
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fehler: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
    }

public class EFP
{
    public static void Main(string[] args)
    {
        int speditionCost= 5;

        Console.WriteLine("Inserisci il nome del cliente: ");
        string clientName = Console.ReadLine();

        Console.WriteLine("\nInserisci il numero dei libri acquistati: ");
        int booksToBuy= int.Parse(Console.ReadLine());

        Console.WriteLine("\nInserisci il costo per il singolo libro: ");
        int bookCost = int.Parse(Console.ReadLine());

        bool isStudent = false;
        string studentAnswer;
        do
        {
            Console.WriteLine("\nSei uno studente? Y/N");
            studentAnswer = Console.ReadLine();
            if (studentAnswer.ToLower() == "y")
            {
                isStudent = true;
            }
            else if (studentAnswer.ToLower() == "n")
            {
                break;
            } else
            {
                Console.WriteLine("Inserisci un valore valido");
            }
        } while (!(studentAnswer.ToLower()=="y"|| studentAnswer.ToLower()=="n"));

        bool spedition = false;
        int speditionMethod;
        do
        {
            Console.WriteLine("\nInserisci il metodo di spedizione:");
            Console.WriteLine("1) Spedizione\n2) Ritiro sul posto");
            speditionMethod = int.Parse(Console.ReadLine());
            if (speditionMethod == 1)
            {
                spedition = true;
            }
            else if (speditionMethod == 2)
            {
                spedition = false;
                speditionCost = 0;
            }
            else
            {
                Console.WriteLine("Inserisci un valore valido");
            }
        } while (!(speditionMethod==1 || speditionMethod==2));

        int subtotal = bookCost * booksToBuy + speditionCost;

        if (booksToBuy <= 5)
        {
            Console.WriteLine($"Ci dispiace {clientName} ma non possiamo eseguire l'ordine.");
        }
        else if (booksToBuy >= 5)
        {
            Console.WriteLine(
                $"\n--------------------------------------------------------------\n" +
                $"\nCLIENTE : {clientName}\n" +
                $"\nTIPOLOGIA DI CLIENTE: {(isStudent ? "STUDENTE" : "CLIENTE GENERICO")}\n\n" +
                $"LIBRI DA COMPRARE: {booksToBuy}\n" +
                $"COSTO PER SINGOLO LIBRO: {bookCost}\n\n" +
                $"METODO DI SPEDIZIONE: {(spedition ? "SPEDIZIONE A CASA" : "RITIRO SUL POSTO")}\n" +
                $"COSTO DI SPEDIZIONE: {speditionCost}\n\n" +
                $"                           SUBTOTALE                          \n" + 
                $"                           {subtotal} EUR                     \n" +
                $"--------------------------------------------------------------");
            Console.WriteLine($"\nGrazie {clientName}! Per aver effettuato l'ordine.");
        }
    }
}
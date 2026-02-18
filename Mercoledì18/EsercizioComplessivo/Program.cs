using System;

class EsercizioComplessivo
{
    public static void Main(string[] args)
    {
        string login = "", nomeUtente = "";
        int password = 0;
        bool continua = true;

        Console.WriteLine("Hai già un account? si/no: ");
        login = Console.ReadLine();

        while (continua)
        {
            switch (login)
            {
                case "no":
                Console.WriteLine("Inserisci il tuo nome utente: ");
                nomeUtente = Console.ReadLine();
                Console.WriteLine("Inserisci la tua password: ");
                password = int.Parse(Console.ReadLine());
                break;

                default:
                    Console.WriteLine("Inserisci il tuo nome utente: ");
                    string tmp = Console.ReadLine();
                    if(tmp != nomeUtente)
                    {
                        Console.WriteLine("Nome utente non valido!");
                        break;
                    }
                    Console.WriteLine("Inserisci la tua password: ");
                    int tmp_password = int.Parse(Console.ReadLine());
                    if(tmp_password != password)
                    {
                        Console.WriteLine("Password non valida!");
                        break;
                    }
                    else
                    {
                        do
                        {    
                            Console.WriteLine("Inserisci da dove far partire il conto alla rovescia: ");
                            int countdown = int.Parse(Console.ReadLine());
                            for (int i = countdown; i >= 0; i--)
                            {
                                Console.WriteLine($"conto alla rovescia: {i}");
                            }

                            Console.WriteLine("Vuoi continuare? (true/false): ");
                            continua = bool.Parse(Console.ReadLine());
                        } while (continua);
                    }                
                    break;
            
            }
        
        }

    }
}
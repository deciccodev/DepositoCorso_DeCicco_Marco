using System;

class EserciziPomeriggio
{
    const int PASSWORD = 123;
    public static void Main(string[] args)
    {
        //ESERCIZIO 1
        /*Console.Write("inserisci un numero intero: ");
        int numero = int.Parse(Console.ReadLine());

        if(numero % 2 == 0)
        {
            Console.Write("il numero inserito è pari!");
        }

        else
        {
            Console.Write("il numero inserito è dispari!");
        }*/


        //ESERCIZIO 2
        /*Console.Write("inserisci una password numerica: ");
        int pass = int.Parse(Console.ReadLine());

        if(pass == PASSWORD)
        {
            Console.WriteLine("Accesso consentito");
        }

        else
        {
            Console.WriteLine("Accesso negato");
        }*/


        //ESERCIZIO 3
        Console.Write("inserisci un numero double: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("inserisci un altro numero double: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("inserisci l'operatore + o - : ");
        string operatore = Console.ReadLine();

        if(operatore == "+")
        {
            double sum = num1 + num2;
            Console.Write($"la somma dei numeri è: {sum}");
        }

        else if(operatore == "-")
        {
            double sum = num1 - num2;
            Console.Write($"la sottrazione dei numeri è: {sum}");
        }

        else
        {
            Console.Write("Operatore non valido");
        }
    }
}
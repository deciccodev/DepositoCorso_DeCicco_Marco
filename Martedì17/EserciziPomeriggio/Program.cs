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
        /*Console.Write("inserisci un numero double: ");
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
        }*/

        //ESERCIZI IF-ELSE 1
        /*Console.Write("inserisci un voto da 1 a 10: ");
        int valutazione = int.Parse(Console.ReadLine());

        if (valutazione <= 4)
        {
            Console.Write("Insufficiente");
        }
        else if (valutazione <= 6)
        {
            Console.WriteLine("Sufficiente");
        }
        else if (valutazione <= 8)
        {
            Console.WriteLine("Buono");
        }
        else
        {
            Console.WriteLine("Ottimo");
        }*/


        //ESERCIZI IF-ELSE 2
        /*Console.Write("inserisci il peso in kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("inserisci l'altezza in metri: ");
        double altezza = double.Parse(Console.ReadLine());

        double bmi = peso / (altezza * altezza);

        if(bmi < 18.5)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, sei Sottopeso");
        }
        else if(bmi < 25)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, sei Normopeso");
        }
        else if(bmi < 30)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, sei Sovrappeso");
        }
        else if(bmi >= 30)
        {
            Console.WriteLine($"la tua bmi è uguale a: {bmi}, Obesità");
        }*/


        //ESERCIZI IF-ELSE Extra
        Console.Write("inserisci il valore da convertire: ");
        double valore = double.Parse(Console.ReadLine());

        Console.Write("inserisci in cosa vuoi convertire il valore (scegli tra x, y, z): ");
        string conversione = Console.ReadLine();

        if(conversione == "x")
        {
            int tmp = (int)valore;
            Console.Write($"il valore è stato convertito in intero: {tmp}");
        }
        else if(conversione == "y")
        {
            float tmp = (float)valore;
            Console.Write($"il valore è stato convertito in float: {tmp}");
        }
        else if(conversione == "z")
        {
            Console.Write("non sapevo in cosa convertirlo :')");
        }
    }
}
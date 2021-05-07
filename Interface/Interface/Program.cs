using System;

namespace Interface
{
    interface Teacher
    {
        double DoMath(double a, double b);
    }
    interface Artist
    {
        string Sing();
    }
    interface Cashier
    {
        int MoneyCount(int money);
    }
    class Jobs : Teacher, Artist, Cashier //Jobs ärver Teacher, Artist och Cashier och definierar metoderna.
    {
        double Teacher.DoMath(double a, double b)
        {
            return a + b;
        }

        string Artist.Sing()
        {
            string[] authors = {"La","Di","Da"};
            Random rnd = new Random();
            return authors[rnd.Next(authors.Length)];
        }
        int Cashier.MoneyCount(int money)
        {
            return money - 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher Emil = new Jobs(); 
            Artist Johnny = new Jobs();
            Cashier Ikaros = new Jobs();

            Console.WriteLine(Emil.DoMath(2, 4)); //Endast Interfacen Teacher har tillgång till metoderna från klassen Jobs som är definierade i Interfacen.
            Console.WriteLine(Johnny.Sing());
            Console.WriteLine(Ikaros.MoneyCount(100));
        }
    }
}

using System;

namespace TypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex.1
            string name = "imie";
            string surname = "nazwisko";
            int age = 45;
            char gender = 'm';
            long pesel = 78021204221;
            long employee_id = 2509324094;

            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(pesel);
            Console.WriteLine(employee_id);
            Console.WriteLine();

            // ex.2
            char char1 = 'A';
            char char2 = 'B';
            char char3 = 'C';

            Console.WriteLine("Zmienne w odwrotnej kolejności:");
            Console.WriteLine(char3);
            Console.WriteLine(char2);
            Console.WriteLine(char1);
            Console.WriteLine();

            // ex.3
            double width = 3.0;
            double length = 4.0;

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

            Console.WriteLine($"Długość przekątnej: {diagonal}");

            // ex.4
            int var_a = 10;
            string var_b = "Szkoła Dotneta";
            double var_c = 12.5;

            Console.WriteLine(var_a);
            Console.WriteLine(var_b);
            Console.WriteLine(var_c);

            //ex.5
            Console.WriteLine("Podaj swoje dane personalne:");

            Console.Write("Imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("telefon: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            string emailAddress = Console.ReadLine();

            Console.Write("Wzrost (in cm): ");
            string height = Console.ReadLine();

            Console.Write("Waga (in kg): ");
            string weight = Console.ReadLine();

            Console.WriteLine("\nTwoje dane personalne to:");
            Console.WriteLine($"Imię: {firstName}");
            Console.WriteLine($"Nazwisko: {lastName}");
            Console.WriteLine($"Telefon: {long.Parse(phoneNumber)}");
            Console.WriteLine($"Email: {emailAddress}");
            Console.WriteLine($"Wzrost: {int.Parse(height)} cm");
            Console.WriteLine($"Waga: {double.Parse(weight)} kg");
        }
    }
}

// See https://aka.ms/new-console-template for more information



using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

List<Dane> data = new List<Dane>();
data.Add(new Dane
{
    Id = 1,
    Name = "Jan",
    Surname = "Nowak",
    NumberAacount = "001",
    Cash = 1457.23M,
});
data.Add(new Dane
{
    Id = 2,
    Name = "Agnieszka",
    Surname = "Kowalska",
    NumberAacount = "002",
    Cash = 3600.18M,
});
data.Add(new Dane
{
    Id = 3,
    Name = "Robert",
    Surname = "Lewandowski",
    NumberAacount = "003",
    Cash = 2745.03M,
});
data.Add(new Dane
{
    Id = 4,
    Name = "Zofia",
    Surname = "Płucińska",
    NumberAacount = "004",
    Cash = 7344.00M,
});
data.Add(new Dane
{
    Id = 5,
    Name = "Grzegorz",
    Surname = "Braun",
    NumberAacount = "005",
    Cash = 455.38M,
});

Console.WriteLine("");
Console.WriteLine("Wybierz opcję:");
Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW");
Console.WriteLine("2 => LOGOWANIE");
Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
Console.Write("WYBIERZ 1, 2 LUB 3");
Console.WriteLine();
int x = int.Parse(Console.ReadLine());
Console.WriteLine();



if (x == 1)
{
    Console.Clear();
    foreach (var Element in data)
    {


        Console.Write(Element.Id + " | " + Element.Name + " " + Element.Surname + " | " + Element.NumberAacount + " | " + Element.Cash + " zł");
        Console.WriteLine();
        Console.WriteLine();

    }
    Console.WriteLine("");
    Console.WriteLine("Wybierz opcję:");
    Console.WriteLine("1 => LISTA WSZYSTKICH KLIJENTÓ");
    Console.WriteLine("2 => LOGOWANIE");
    Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
    Console.Write("WYBIERZ 1, 2 LUB 3");
    Console.WriteLine();
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (x2 == 2)
    {
        Console.Clear();
        Console.WriteLine("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA");
        int id = int.Parse(Console.ReadLine());
        foreach (var ID in data)
        {
            if (id == ID.Id)
            {
                Console.Clear();
                Console.Write(ID.Id + " | " + ID.Name + " " + ID.Surname + " | " + ID.NumberAacount + " | " + ID.Cash + " zł");
                Console.WriteLine();
                Console.WriteLine(" WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine();
                foreach (var COUNT in data)
                {
                    if (count == COUNT.Id)
                    {
                        Console.Clear();
                        Console.WriteLine("PODAJ KWOTĘ PRZELEWU");
                        decimal CASH = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Clear();
                        if (CASH < ID.Cash)
                        {
                            ID.Cash = ID.Cash - CASH;
                            COUNT.Cash = COUNT.Cash + CASH;
                            foreach (var Elemen in data)
                            {
                                Console.Write(Elemen.Id + " | " + Elemen.Name + " " + Elemen.Surname + " | " + Elemen.NumberAacount + " | " + Elemen.Cash + " zł");
                                Console.WriteLine();
                                Console.WriteLine();

                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("PRZELEW SIĘ UDAŁ");
                            Console.ResetColor();
                        }
                        else if (CASH > ID.Cash)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Masz za mało pieniędzy");
                            Console.WriteLine();
                            Console.ResetColor();

                        }
                    }
                }
            }
        }
    }
}
else if (x == 2)
{
    Console.Clear();
    Console.WriteLine("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA");
    int id = int.Parse(Console.ReadLine());
    foreach (var ID in data)
    {
        if (id == ID.Id)
        {
            Console.Clear();
            Console.Write(ID.Id + " | " + ID.Name + " " + ID.Surname + " | " + ID.NumberAacount + " | " + ID.Cash + " zł");
            Console.WriteLine();
            Console.WriteLine(" WPISZ NUMER KONTA NA KTÓRY CHCESZ WYKONAĆ PRZELEW");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (var COUNT in data)
            {
                if (count == COUNT.Id)
                {
                    Console.Clear();
                    Console.WriteLine("PODAJ KWOTĘ PRZELEWU");
                    decimal CASH = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Clear();
                    if (CASH < ID.Cash)
                    {
                        ID.Cash = ID.Cash - CASH;
                        COUNT.Cash = COUNT.Cash + CASH;
                        Console.Clear();
                        foreach (var Elemen in data)
                        {

                            Console.Write(Elemen.Id + " | " + Elemen.Name + " " + Elemen.Surname + " | " + Elemen.NumberAacount + " | " + Elemen.Cash + " zł");
                            Console.WriteLine();
                            Console.WriteLine();

                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("PRZELEW SIĘ UDAŁ");
                        Console.ResetColor();
                    }
                    else if (CASH > ID.Cash)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Masz za mało pieniędzy");
                        Console.WriteLine();
                    }
                }

            }
        }

    }
}
else if (x == 3)
{
    Console.Clear();
}
else
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("PODAŁEŚ ZŁE LICZBY URUCHOM PROGRAM JESZCZE RAZ");
    Console.Clear();
}
Console.ReadLine();
class Dane
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? NumberAacount { get; set; }
    public decimal Cash { get; set; }
}
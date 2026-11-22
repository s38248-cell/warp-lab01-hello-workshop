using System.Collections.Generic;

int[] zlotoWTurach = { 5, 12, 0, 8, 15 };

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
}

Console.WriteLine();

int sumaZlota = 0;
int powyzejDziesiec = 0;

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    sumaZlota += zlotoWTurach[i];

    if (zlotoWTurach[i] >= 10)
    {
        powyzejDziesiec += 1;
    }
}

Console.WriteLine($"Łącznie: {sumaZlota} sztuk");
Console.WriteLine($"Średnio na turę: {(double)sumaZlota / zlotoWTurach.Length} sztuk");
Console.WriteLine($"Tury z wynikiem co najmniej 10: {powyzejDziesiec}");
Console.Write("Od końca: ");

for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
    Console.WriteLine(zlotoWTurach[i] + ", ");
};


Console.WriteLine("=====================================");

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};

int liczbaPrzedmiotow = plecak.Count;

Console.WriteLine($"Plecak ({liczbaPrzedmiotow}/6):");

foreach (string przedmiot in plecak)
{
    Console.WriteLine($"({plecak.IndexOf(przedmiot) + 1}). {przedmiot}");
}

Console.WriteLine();

Console.Write("Podaj nowy przedmiot: ");
// string nowyPrzedmiot = Console.ReadLine();
string nowyPrzedmiot = "Klucz";

plecak.Add(nowyPrzedmiot);
Console.WriteLine($"Dodano: {nowyPrzedmiot}");

if (plecak.Contains("Mikstura"))
{
    plecak.Remove("Mikstura");
    Console.WriteLine("Użyto mikstury.");
}

Console.WriteLine();

Console.WriteLine($"Plecak ({liczbaPrzedmiotow}/6):");

foreach (string przedmiot in plecak)
{
    Console.WriteLine($"({plecak.IndexOf(przedmiot) + 1}). {przedmiot}");
}


Console.WriteLine("=====================================");

Dictionary<string, int> ceny = new()
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

int liczbaPrzedmiotow2 = ceny.Count;

Console.WriteLine($"Przedmioty ({liczbaPrzedmiotow2}):");

foreach (string przedmiot in ceny.Keys)
{
    Console.WriteLine($"({ceny.Keys.ToList().IndexOf(przedmiot) + 1}). {przedmiot} - {ceny[przedmiot]} złota");
}

Console.Write("Podaj przedmiot: ");
// string item = Console.ReadLine();
string item = "Miecz";

if (ceny.ContainsKey(item))
{
    Console.WriteLine($"{item} kosztuje {ceny[item]}");
}
else
{
    Console.WriteLine($"Przedmiot {item} nie znajduje sie na liście.");
}

ceny["Mikstura"] = 12;

Console.WriteLine();

Console.WriteLine($"Przedmioty ({liczbaPrzedmiotow2}):");

foreach (string przedmiot in ceny.Keys)
{
    Console.WriteLine($"({ceny.Keys.ToList().IndexOf(przedmiot) + 1}). {przedmiot} - {ceny[przedmiot]} złota");
}

Console.WriteLine("=====================================");

List<string> przedmioty = new()
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};

Console.WriteLine($"Lista przedmiotów:");

foreach (string przedmiot in przedmioty)
{
    Console.WriteLine($"({przedmioty.IndexOf(przedmiot) + 1}). {przedmiot}");
}

Console.WriteLine();

var loop = true;

while (loop)
{
    Console.Write("Podaj numer przedmiotu do usunięcia: ");
    var input = Console.ReadLine();

    if (int.TryParse(input, out int itemForRemoval) && itemForRemoval > 0 && itemForRemoval <= przedmioty.Count)
    {
        string nameOfRemovedItem = przedmioty[itemForRemoval - 1];
        przedmioty.RemoveAt(itemForRemoval - 1);
        Console.WriteLine($"Usunięto: {nameOfRemovedItem}");
        loop = false;
    }
    else
    {
        Console.WriteLine("Numer musi być liczbą całkowitą należącą do zakresu 1–4.");
    }

}

Console.WriteLine();

Console.WriteLine($"Lista przedmiotów:");

foreach (string przedmiot in przedmioty)
{
    Console.WriteLine($"({przedmioty.IndexOf(przedmiot) + 1}). {przedmiot}");
}

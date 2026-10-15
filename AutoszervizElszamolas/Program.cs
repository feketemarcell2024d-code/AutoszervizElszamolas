using autoszervizelszamolas;
List<szerelo> Lista = new List<szerelo>();
foreach (string beolvasott in File.ReadAllLines("szerviz.txt"))
{
    string[] adatok = beolvasott.Split(";");

    szerelo aktualis = new szerelo();

    aktualis.nev = adatok[0];
    aktualis.javitottAutok = int.Parse(adatok[1]);
    aktualis.munkaora = int.Parse(adatok[2]);
    aktualis.garancialisjavitasok = int.Parse(adatok[3]);

    Lista.Add(aktualis);
}
Console.WriteLine("Szerelők napi elszámolása:");
int teljesnapiber = 0;
int munkaossz = 0;
int legnagyobbber = 0;
string legjobbdolgozo = "";
int garancialishibanelkul = 0;
for (int i = 0; i < Lista.Count; i++)
{
    int levonas = 0;
    int bonusz = 0;
    if (Lista[i].javitottAutok >= 6 && Lista[i].garancialisjavitasok <= 1)
    {
        bonusz = 15000;
    }
    if (Lista[i].garancialisjavitasok >= 2)
    {
        levonas = 10000;
    }

    Console.WriteLine($"{Lista[i].nev}: {Lista[i].javitottAutok} autó, {Lista[i].munkaora} óra (Garanciális: {Lista[i].garancialisjavitasok}) - munkabér: {(Lista[i].munkaora * 4000) + (Lista[i].javitottAutok * 5000)+bonusz-levonas} Ft ");
    teljesnapiber += (Lista[i].munkaora * 4000) + (Lista[i].javitottAutok * 5000) + bonusz - levonas;
}





double atlagmunka = (double)teljesnapiber / Lista.Count;
Console.WriteLine();
Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"Szerviz által kifizetett teljes munkabér: {teljesnapiber} Ft");
Console.WriteLine($"Átlagos munkaóra szerelőnként: {atlagmunka:F0} óra");
Console.WriteLine($"Legnagyobb napi bér: {legnagyobbber.Nev} ({legnagyobbber.tel} Ft)");
Console.WriteLine($"Garanciális hiba nélkül dolgozó szerelők száma: {garancialishibanelkul} fő");

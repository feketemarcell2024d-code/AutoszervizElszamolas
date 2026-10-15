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
    Console.WriteLine($"{Lista[i].nev}: {Lista[i].javitottAutok} autó, {Lista[i].munkaora} óra (Garanciális: {Lista[i].garancialisjavitasok}) - munkabér: {(Lista[i].munkaora * 4000) + (Lista[i].javitottAutok * 5000)} Ft");
}




double atlagmunka = (double)munkaossz / Lista.Count;
Console.WriteLine();
Console.WriteLine("Összesített statisztika:");
Console.WriteLine($"Szerviz által kifizetett teljes munkabér: {teljesnapiber} Ft");
Console.WriteLine($"Átlagos munkaóra szerelőnként: {atlagmunka:F0} óra");
Console.WriteLine($"Legnagyobb napi bér: {legnagyobbber.Nev} ({legnagyobbber.NapiBer} Ft)");
Console.WriteLine($"Garanciális hiba nélkül dolgozó szerelők száma: {garancialishibanelkul} fő");

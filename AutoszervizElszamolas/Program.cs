using autoszervizelszamolas;
List<szerelo> szerelok = new List<szerelo>();
foreach (string beolvasott in File.ReadAllLines("szerviz.txt"))
{
    string[] adatok = beolvasott.Split(";");
    szerelo aktualis = new szerelo();
    aktualis.nev = adatok[0];
    aktualis.munkaora = int.Parse(adatok[2]); 
    aktualis.javitottAutok = int.Parse(adatok[1]); 
    aktualis.garancialisjavitasok = int.Parse(adatok[3]);
    szerelok.Add(aktualis);
    {
        Console.WriteLine("A szerelok napi elszamolasa: ");
        int oraber;
        int dbar;
        int teljesitmeny;
        int javitasszama
            ;
    }



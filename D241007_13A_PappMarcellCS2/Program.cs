

using D241007_13A_PappMarcellCS2;

List<beolv> beolvasas = [];
using StreamReader sr = new(@"..\..\..\src\forras.txt");
while (!sr.EndOfStream) beolvasas.Add(new(sr.ReadLine()));

Console.WriteLine($"ennyi resztvevo volt:{beolvasas.Count}");

//var atlageletkor = beolvasas.Average( atlageletkor => atlageletkor.szulev);
//Console.WriteLine($"A férfi versenyzők átlag életkora:{atlageletkor/94}");
int i = 0;
foreach (var asd in beolvasas) {
    if (asd.neme == "f") 
    {
        i = 2024-asd.szulev;
    }
}
var elitj = beolvasas.Count(p =>p.kategoria == "elit junior");
Console.WriteLine($"versenyzök száma 'elit junior' kategoriában:{elitj}");
Console.WriteLine($"A férfiak átlag életkora:{i}");
int id2151 = 0;
foreach(var ido2 in beolvasas) 
{

}
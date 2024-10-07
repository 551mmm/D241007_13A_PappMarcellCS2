using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D241007_13A_PappMarcellCS2
{
    internal class beolv
    {
        public beolv(string nev, int szulev, int rajtszam, string neme, string kategoria)
        {
            this.nev = nev;
            this.szulev = szulev;
            this.rajtszam = rajtszam;
            this.neme = neme;
            this.kategoria = kategoria;
        }

        public string nev { get; set;}
        public int szulev { get; set;}
        public int rajtszam { get; set;}
        public string neme { get; set;}
        public string kategoria { get; set;}
        public DateTime ido { get; set;}
        public TimeSpan depo { get; set;}
        public TimeSpan kerekpar { get; set;}
        public TimeSpan masokdikdepo { get; set;}
        public TimeSpan futas { get; set; }
        public beolv(string beolvasottSor)
        {
            string[] darabok = beolvasottSor.Split(';');
            nev = darabok[0];
            szulev = Convert.ToInt16(darabok[1]);
            rajtszam = Convert.ToInt16(darabok[2]);
            neme = darabok[3];
         //   ido=DateTime.Parse(darabok[4]);
            kategoria=darabok[4];

        }
    }

}

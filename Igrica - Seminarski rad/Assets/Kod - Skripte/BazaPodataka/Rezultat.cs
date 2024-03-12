using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Rezultat : MonoBehaviour
{
    [Serializable]
    public class RezultatIgraca
    {
        public string ime;
        public int brojPoena;
        public int brojDistance;
    }

    public static List<RezultatIgraca> rezultati = new List<RezultatIgraca>();

    public Rezultat(string imeIgraca, int brojPoena, int brojDistance)
    {
        UcitajRezultateIzFajla();

        var postojeciIgrac = rezultati.FirstOrDefault(x => x.ime == imeIgraca);

        if (postojeciIgrac != null)
        {
            postojeciIgrac.brojPoena = brojPoena;
            postojeciIgrac.brojDistance = brojDistance;
        }
        else
        {
            rezultati.Add(new RezultatIgraca { ime = imeIgraca, brojPoena = brojPoena, brojDistance = brojDistance });
        }

        SortirajRezultate();

        SacuvajRezultateUFajl();
    }

    private void UcitajRezultateIzFajla()
    {
        string putanjaDoDirektorijuma = Path.Combine(Application.dataPath, "Kod - Skripte", "BazaPodataka");
        string putanjaDoFajla = Path.Combine(putanjaDoDirektorijuma, "Rezultati.txt");

        if (File.Exists(putanjaDoFajla))
        {
            string[] linije = File.ReadAllLines(putanjaDoFajla);

            foreach (var linija in linije)
            {
                string[] delovi = linija.Split(' ');
                if (delovi.Length == 3)
                {
                    string ime = delovi[0];
                    int poeni;
                    int distance;
                    if (int.TryParse(delovi[1], out poeni) && int.TryParse(delovi[2], out distance))
                    {
                        var postojeciIgrac = rezultati.FirstOrDefault(x => x.ime == ime);
                        if (postojeciIgrac != null)
                        {
                            postojeciIgrac.brojPoena = poeni;
                            postojeciIgrac.brojDistance = distance;
                        }
                        else
                        {
                            rezultati.Add(new RezultatIgraca { ime = ime, brojPoena = poeni, brojDistance = distance });
                        }
                    }
                }
            }
        }
    }

    private void SortirajRezultate()
    {
        rezultati = rezultati.OrderByDescending(x => x.brojPoena).ThenByDescending(x => x.brojDistance).ToList();
    }

    private void SacuvajRezultateUFajl()
    {
        string putanjaDoDirektorijuma = Path.Combine(Application.dataPath, "Kod - Skripte", "BazaPodataka");
        string putanjaDoFajla = Path.Combine(putanjaDoDirektorijuma, "Rezultati.txt");

        using (var writer = new StreamWriter(putanjaDoFajla))
        {
            foreach (var rez in rezultati)
            {
                string podaciZaZapis = $"{rez.ime} {rez.brojPoena} {rez.brojDistance}";
                writer.WriteLine(podaciZaZapis);
            }
        }
    }
}

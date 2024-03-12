using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class TabelaRezultata : MonoBehaviour
{
    public TMP_Text[] txtIme;
    public TMP_Text[] txtPoeni;
    public TMP_Text[] txtDistanca;

    private void Start()
    {
        string putanjaDoDirektorijuma = Path.Combine(Application.dataPath, "Kod - Skripte", "BazaPodataka");
        string putanjaDoFajla = Path.Combine(putanjaDoDirektorijuma, "Rezultati.txt");

        if (File.Exists(putanjaDoFajla))
        {
            string[] linije = File.ReadAllLines(putanjaDoFajla);

            HashSet<string> dodatiIgraci = new HashSet<string>();

            int index = 0;

            for (int i = 0; i < linije.Length && index < txtIme.Length; i++)
            {
                string[] delovi = linije[i].Split(' ');
                if (delovi.Length == 3)
                {
                    string imeIgraca = delovi[0];
                    int poeni = int.Parse(delovi[1]);
                    int distanca = int.Parse(delovi[2]);

                    if (!dodatiIgraci.Contains(imeIgraca))
                    {
                        txtIme[index].text = imeIgraca;
                        txtPoeni[index].text = poeni.ToString();
                        txtDistanca[index].text = distanca.ToString();
                        dodatiIgraci.Add(imeIgraca);
                        index++;
                    }
                }
            }

            for (int i = index; i < txtIme.Length; i++)
            {
                txtIme[i].text = "";
                txtPoeni[i].text = "";
                txtDistanca[i].text = "";
            }
        }
        else
        {
            for (int i = 0; i < txtIme.Length; i++)
            {
                txtIme[i].text = "";
                txtPoeni[i].text = "";
                txtDistanca[i].text = "";
            }
        }
    }
}

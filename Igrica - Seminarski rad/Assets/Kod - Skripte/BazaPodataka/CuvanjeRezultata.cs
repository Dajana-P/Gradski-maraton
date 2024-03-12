using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CuvanjeRezultata : MonoBehaviour
{
    public GameObject inputIme;
    public GameObject brPoena;
    public GameObject brDistance;
    public bool sacuvano = false;

    public void Cuvanje()
	{
        if(sacuvano == false)
		{
            Rezultat rezultat = new Rezultat(inputIme.GetComponent<TMP_InputField>().text, int.Parse(brPoena.GetComponent<TextMeshProUGUI>().text), int.Parse(brDistance.GetComponent<TextMeshProUGUI>().text));
            sacuvano = true;

            brDistance.GetComponent<TextMeshProUGUI>().text = "0";
            brPoena.GetComponent<TextMeshProUGUI>().text = "0";
        }
    }
}

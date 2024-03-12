using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PoenKontrola : MonoBehaviour
{
    public static int brPoena;
    public GameObject prikazBrPoena;
    public GameObject konacniprikazBrPoena;

    // Update is called once per frame
    void Update()
    {
        prikazBrPoena.GetComponent<TextMeshProUGUI>().text = brPoena.ToString();
        konacniprikazBrPoena.GetComponent<TextMeshProUGUI>().text = brPoena.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Distanca : MonoBehaviour
{
    public GameObject prikazDistance;
    public GameObject konacniPrikazDistance;
    public static int predjenaDistanca;
    public bool dodavanjeDistance = false;
    public float kasnjenje = 0.4f;
    public GameObject igrac;

    // Update is called once per frame
    void Update()
    {
        if(IgracKretanje.pomeranje == true)
		{
            if (dodavanjeDistance == false)
            {
                dodavanjeDistance = true;
                StartCoroutine(DodavanjeDistance());
            }
        }
        
    }

    IEnumerator DodavanjeDistance()
	{
        predjenaDistanca++;
        prikazDistance.GetComponent<TextMeshProUGUI>().text = predjenaDistanca.ToString();
        konacniPrikazDistance.GetComponent<TextMeshProUGUI>().text = predjenaDistanca.ToString();
        yield return new WaitForSeconds(kasnjenje);
        dodavanjeDistance = false;
        if(IgracKretanje.pomeranje == true)
		{
            igrac.GetComponent<IgracKretanje>().brzinaKretanja += 0.1f;
            igrac.GetComponent<IgracKretanje>().brzinaPomeranjaLevoIDesno += 0.05f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorNivoa : MonoBehaviour
{
    public GameObject[] sekcija;
    public int zPozicija = 50;
    public bool kreiranjeSekcije = false;
    public int brSekcije;

    // Update is called once per frame
    void Update()
    {
        if(kreiranjeSekcije == false)
		{
            kreiranjeSekcije = true;
            StartCoroutine(GeneratorSekcije());
		}
    }

    IEnumerator GeneratorSekcije()
	{
        brSekcije = Random.Range(0, 3);
        Instantiate(sekcija[brSekcije], new Vector3(0, 0, zPozicija), Quaternion.identity);
        zPozicija = zPozicija + 50;
        yield return new WaitForSeconds(4);
        kreiranjeSekcije = false;
    }
}

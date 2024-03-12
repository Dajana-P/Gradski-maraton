using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrajIgre : MonoBehaviour
{
    public GameObject distanca;
    public GameObject poeni;
    public GameObject krajPrikaz;
    public GameObject fadeOut;
    public GameObject generator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Kraj());
    }

    IEnumerator Kraj()
    {
        yield return new WaitForSeconds(2);
        distanca.SetActive(false);
        poeni.SetActive(false);
        krajPrikaz.SetActive(true);
        IgracKretanje.pomeranje = false;
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(true);
        fadeOut.GetComponent<Animator>().enabled = true;
        generator.GetComponent<GeneratorNivoa>().enabled = false;
    }
}
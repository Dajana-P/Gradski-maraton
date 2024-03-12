using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocetakIgre : MonoBehaviour
{
    public GameObject br3;
    public GameObject br2;
    public GameObject br1;
    public GameObject kreni;
    public AudioSource ding;
    public AudioSource kreniDing;
    public GameObject igrac;
    public GameObject modelIgraca;
    public GameObject poeni;
    public GameObject distanca;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Odbrojavanje());
    }
    IEnumerator Odbrojavanje()
    {
        igrac.GetComponent<IgracKretanje>().brzinaKretanja = 0;
        modelIgraca.GetComponent<Animator>().Play("Idle");
        ding.Play();
        br3.SetActive(true);
        yield return new WaitForSeconds(1);
        br2.SetActive(true);
        ding.Play();
        yield return new WaitForSeconds(1);
        br1.SetActive(true);
        ding.Play();
        yield return new WaitForSeconds(1);
        kreniDing.Play();
        kreni.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        poeni.SetActive(true);
        distanca.SetActive(true);
        modelIgraca.GetComponent<Animator>().Play("Fast Run");
        igrac.GetComponent<IgracKretanje>().brzinaKretanja = 4;
        IgracKretanje.pomeranje = true;
    }
}

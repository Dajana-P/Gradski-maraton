using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnistavacNivoa : MonoBehaviour
{
    public string nazivObjekta;

    // Start is called before the first frame update
    void Start()
    {
        nazivObjekta = transform.name;
        StartCoroutine(Unistavac());
    }

    IEnumerator Unistavac()
	{
        yield return new WaitForSeconds(29);
        if (nazivObjekta == "Sekcija(Clone)") 
		{
            Destroy(gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgracKretanje : MonoBehaviour
{
    public float brzinaKretanja = 4;
    public float brzinaPomeranjaLevoIDesno = 4;
    static public bool pomeranje = false;
    public GameObject kontrola;
    public GameObject modelIgraca;
    public bool skace = false;
    public bool pada = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * brzinaKretanja, Space.World);
        if (pomeranje == true)
		{
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < Granica.desnaStrana)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * brzinaPomeranjaLevoIDesno * -1);
                }
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > Granica.levaStrana)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * brzinaPomeranjaLevoIDesno);
                }
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (skace == false)
                {
                    skace = true;
                    modelIgraca.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(Skakanje());
                }
            }
        }
        
        if (skace == true)
		{
			if (pada == false)
			{
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
			}
            if (pada == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            kontrola.GetComponent<KrajIgre>().enabled = true;
            pomeranje = false;
            brzinaKretanja = 0;
            brzinaPomeranjaLevoIDesno = 0;
            modelIgraca.GetComponent<Animator>().Play("Stumble Backwards");
        }
    }
    IEnumerator Skakanje()
	{
        float pocetnaVisina = transform.position.y;
        yield return new WaitForSeconds(0.27f);
        pada = true;
        yield return new WaitForSeconds(0.27f);
        skace = false;
        pada = false;
        modelIgraca.GetComponent<Animator>().Play("Fast Run");
        transform.position = new Vector3(transform.position.x, pocetnaVisina, transform.position.z);
    }
}

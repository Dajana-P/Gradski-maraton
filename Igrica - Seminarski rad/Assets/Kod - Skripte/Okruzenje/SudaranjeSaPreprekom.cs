using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudaranjeSaPreprekom : MonoBehaviour
{
	public GameObject igrac;
	public GameObject modelIgraca;
	public AudioSource sudar;
	public GameObject kamera;
	public GameObject kontrola;
	private void OnTriggerEnter(Collider other)
	{
		this.gameObject.GetComponent<Collider>().enabled = false;
		igrac.GetComponent<IgracKretanje>().enabled = false;
		modelIgraca.GetComponent<Animator>().Play("Stumble Backwards");
		kontrola.GetComponent<Distanca>().enabled = false;
		sudar.Play();
		kamera.GetComponent<Animator>().enabled = true;
		kontrola.GetComponent<KrajIgre>().enabled = true;
	}
}

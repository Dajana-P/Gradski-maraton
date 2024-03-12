using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SakupljanjePoena : MonoBehaviour
{
	public AudioSource poenFX;
	private void OnTriggerEnter(Collider other)
	{
		poenFX.Play();
		PoenKontrola.brPoena++; 
		this.gameObject.SetActive(false);
	}
}

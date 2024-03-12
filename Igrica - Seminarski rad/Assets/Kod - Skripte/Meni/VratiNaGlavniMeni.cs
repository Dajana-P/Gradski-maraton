using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VratiNaGlavniMeni : MonoBehaviour
{
    public GameObject distanca;
    public GameObject poeni;
    public void GlavniMeni()
    {
        GetComponent<CuvanjeRezultata>().sacuvano = false;
        SceneManager.LoadScene(0);
    }
}

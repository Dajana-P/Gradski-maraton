using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PokreniIgricu : MonoBehaviour
{
    public void Pokreni()
    {
        PoenKontrola.brPoena = 0;
        Distanca.predjenaDistanca = 0;
        SceneManager.LoadScene(1);
    }
}

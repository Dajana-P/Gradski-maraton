using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotiranjeZaGlavniMeni : MonoBehaviour
{
    public float brzinaRotiranja;

    // Update is called once per frame
    void Update()
    {
        brzinaRotiranja = Random.Range(-1, 1);
        transform.Rotate(0, brzinaRotiranja, 0, Space.World);
    }
}

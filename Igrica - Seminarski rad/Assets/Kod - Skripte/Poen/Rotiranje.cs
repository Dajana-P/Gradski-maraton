using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotiranje : MonoBehaviour
{
    public float brzinaRotiranja = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, brzinaRotiranja, 0, Space.World);
    }
}

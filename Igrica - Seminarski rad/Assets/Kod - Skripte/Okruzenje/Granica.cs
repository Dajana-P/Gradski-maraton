using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granica : MonoBehaviour
{
    public static float desnaStrana = 3f;
    public static float levaStrana = -3;

    public float unutrasnjaDesna;
    public float unutrasnjaLeva;

    // Update is called once per frame
    void Update()
    {
        unutrasnjaDesna = desnaStrana;
        unutrasnjaLeva = levaStrana;
    }
}

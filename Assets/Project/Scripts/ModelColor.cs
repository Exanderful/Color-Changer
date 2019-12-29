using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelColor : MonoBehaviour
{
    void Start()
    {
        if (gameObject.name == "Sphere")
        {
            if (PlayerPrefs.GetString("SphereColor") == "black")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.black);
            }
            if (PlayerPrefs.GetString("SphereColor") == "white")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
            if (PlayerPrefs.GetString("SphereColor") == "yellow")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
            }
        }
        if (gameObject.name == "Cube")
        {
            if (PlayerPrefs.GetString("CubeColor") == "black")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.black);
            }
            if (PlayerPrefs.GetString("CubeColor") == "white")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
            if (PlayerPrefs.GetString("CubeColor") == "yellow")
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLaunch : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("FirstLaunch") == 0)
        {
            PlayerPrefs.SetString("SphereColor", "white");
            PlayerPrefs.SetString("CubeColor", "black");
            PlayerPrefs.SetInt("FirstLaunch", 1);
        }
    }
}

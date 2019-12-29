using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStateManager : MonoBehaviour
{
    public Vector3 DefaultPosition;
    public GameObject[] Models;
    public static bool ModelSelected = false;

    float time;
    Vector3 CorrectingViewVector;

    private void Start()
    {
        CorrectingViewVector = new Vector3(0f, -0.35f, 2f);
    }

    private void Update()
    {
        if (!ModelSelected)
        {
            if (transform.position != DefaultPosition)
            {
                transform.position = Vector3.Lerp(transform.position, DefaultPosition, time);
                time += Time.deltaTime;
            }
            else
            {
                time = 0;
            }
        }
        else
        {
            if(transform.position != Models[PlayerPrefs.GetInt("ModelSelected")].transform.position - CorrectingViewVector)
            {
                transform.position = Vector3.Lerp(transform.position, Models[PlayerPrefs.GetInt("ModelSelected")].transform.position - CorrectingViewVector, time);
                time += Time.deltaTime;
            }
            else
            {
                time = 0;
            }
        }
    }
}

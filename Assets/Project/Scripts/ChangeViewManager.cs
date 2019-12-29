using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewManager : MonoBehaviour
{
    public GameObject[] ViewPanels;

    public void ChangeViewPanel()
    {
        if (CameraStateManager.ModelSelected)
        {
            ViewPanels[0].transform.localScale = new Vector3(1f, 1f, 1f);
            ViewPanels[1].transform.localScale = new Vector3(0f, 0f, 0f);
        }
        else
        {
            ViewPanels[0].transform.localScale = new Vector3(0f, 0f, 0f);
            ViewPanels[1].transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}

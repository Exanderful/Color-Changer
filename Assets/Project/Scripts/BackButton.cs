using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject[] ViewPanels;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        GameObject.Find("ChangeViewObject").GetComponent<ChangeViewManager>().ChangeViewPanel();
        CameraStateManager.ModelSelected = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelChangeButton : MonoBehaviour
{
    public enum Model
    {
        Sphere,
        Cube
    };
    public Model model;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if(model == Model.Sphere)
        {
            PlayerPrefs.SetInt("ModelSelected", 0);
        }
        if (model == Model.Cube)
        {
            PlayerPrefs.SetInt("ModelSelected", 1);
        }
        GameObject.Find("ChangeViewObject").GetComponent<ChangeViewManager>().ChangeViewPanel();
        CameraStateManager.ModelSelected = true;
    }
}

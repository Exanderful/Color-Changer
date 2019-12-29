using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeButton : MonoBehaviour
{
    public enum ModelColor
    {
        Black,
        White,
        Yellow
    };
    public ModelColor modelColor;

    public Text childText;

    string whichModelColor;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("ModelSelected") == 0)
        {
            whichModelColor = "SphereColor";
        }
        else if(PlayerPrefs.GetInt("ModelSelected") == 1)
        {
            whichModelColor = "CubeColor";
        }
        if (CameraStateManager.ModelSelected)
        {
            if (modelColor == ModelColor.Black)
            {
                if (PlayerPrefs.GetString(whichModelColor) == "black")
                {
                    childText.text = "Этот цвет выбран";

                }
                else
                {
                    childText.text = "";
                }
            }
            if (modelColor == ModelColor.White)
            {
                if (PlayerPrefs.GetString(whichModelColor) == "white")
                {
                    childText.text = "Этот цвет выбран";

                }
                else
                {
                    childText.text = "";
                }
            }
            if (modelColor == ModelColor.Yellow)
            {
                if (PlayerPrefs.GetString(whichModelColor) == "yellow")
                {
                    childText.text = "Этот цвет выбран";

                }
                else
                {
                    childText.text = "";
                }
            }
        }
    }

    void OnClick()
    {
        if(modelColor == ModelColor.Black)
        {
            if(PlayerPrefs.GetInt("ModelSelected") == 0)
            {
                GameObject.Find("Sphere").GetComponent<Renderer>().material.SetColor("_Color", Color.black);
                PlayerPrefs.SetString(whichModelColor, "black");
            }
            if (PlayerPrefs.GetInt("ModelSelected") == 1)
            {
                GameObject.Find("Cube").GetComponent<Renderer>().material.SetColor("_Color", Color.black);
                PlayerPrefs.SetString(whichModelColor, "black");
            }
        }
        if (modelColor == ModelColor.White)
        {
            if (PlayerPrefs.GetInt("ModelSelected") == 0)
            {
                GameObject.Find("Sphere").GetComponent<Renderer>().material.SetColor("_Color", Color.white);
                PlayerPrefs.SetString(whichModelColor, "white");
            }
            if (PlayerPrefs.GetInt("ModelSelected") == 1)
            {
                GameObject.Find("Cube").GetComponent<Renderer>().material.SetColor("_Color", Color.white);
                PlayerPrefs.SetString(whichModelColor, "white");
            }
        }
        if (modelColor == ModelColor.Yellow)
        {
            if (PlayerPrefs.GetInt("ModelSelected") == 0)
            {
                GameObject.Find("Sphere").GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
                PlayerPrefs.SetString(whichModelColor, "yellow");
            }
            if (PlayerPrefs.GetInt("ModelSelected") == 1)
            {
                GameObject.Find("Cube").GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
                PlayerPrefs.SetString(whichModelColor, "yellow");
            }
        }
    }
}

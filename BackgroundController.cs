using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    public Camera camera;
    public Color dayColor;
    public Color nightColor;
    void OnEnable()
    {
        EventManager.OnClicked += SwitchColor;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= SwitchColor;
    }

    void SwitchColor()
    {
        if(camera.backgroundColor == dayColor)
        {
            camera.backgroundColor = nightColor;
        } else {
            camera.backgroundColor = dayColor;            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light;
    void OnEnable()
    {
        EventManager.OnClicked += SwitchLight;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= SwitchLight;
    }

    void SwitchLight()
    {
        if(light.intensity == 1f)
        {
            light.intensity = 0f;
        } else {
            light.intensity = 1f;            
        }
    }
}

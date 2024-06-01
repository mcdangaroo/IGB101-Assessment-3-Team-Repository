using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkyboxChanger : MonoBehaviour
{
    // Set new skybox material. 
    public Material newSkybox; 
    private bool hasChanged = false; // 

    private void OnTriggerEnter(Collider other)
    {
        if (!hasChanged && other.CompareTag("ChangeSkybox"))
        {
            ChangeSkybox(newSkybox);
            hasChanged = true; 
        }
    }

    private void ChangeSkybox(Material skybox)
    {
        RenderSettings.skybox = skybox;
        DynamicGI.UpdateEnvironment();
    }
}


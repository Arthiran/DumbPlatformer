using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxBlending : MonoBehaviour
{
    public Camera cam;

    public Material blueSky;
    public Material greenSky;
    public Material yellowSky;
    public Material orangeSky;
    public Material redSky;

    private void Start()
    {
        float randomNum = Random.Range(0, 5);

        if (randomNum == 0)
        {
            RenderSettings.skybox = blueSky;
        }
        else if (randomNum == 1)
        {
            RenderSettings.skybox = greenSky;
        }
        else if (randomNum == 2)
        {
            RenderSettings.skybox = yellowSky;
        }
        else if (randomNum == 3)
        {
            RenderSettings.skybox = orangeSky;
        }
        else if (randomNum == 4)
        {
            RenderSettings.skybox = redSky;
        }

        DynamicGI.UpdateEnvironment();
    }
}

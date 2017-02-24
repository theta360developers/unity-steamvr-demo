using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamDualEyed : MonoBehaviour
{

    public GameObject sphere1;
    //Second Camera Added by Meg
    public GameObject sphere2;
    public int cameraNumber = 1;

    private WebCamTexture webCamTexture;
    private WebCamDevice webCamDevice;

    void Start()
    {
        // Checks how many and which cameras are available on the device
        for (int cameraIndex = 0; cameraIndex < WebCamTexture.devices.Length; cameraIndex++)
        {
            Debug.Log("WebCamDevice " + cameraIndex + " name " + WebCamTexture.devices[cameraIndex].name);
        }

        if (WebCamTexture.devices.Length > cameraNumber)
        {
            webCamDevice = WebCamTexture.devices[cameraNumber];
            webCamTexture = new WebCamTexture(webCamDevice.name, 1280, 720);
            sphere1.GetComponent<Renderer>().material.mainTexture = webCamTexture;
            //Added by Meg
            sphere2.GetComponent<Renderer>().material.mainTexture = webCamTexture;
            webCamTexture.Play();
        }
        else
        {
            Debug.Log("no camera");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlay : MonoBehaviour {

    public GameObject Sphere1;
    public GameObject Sphere2;

    void Start()
    {
        MovieTexture video360_1 = (MovieTexture)Sphere1.GetComponent<Renderer>().material.mainTexture;
        MovieTexture video360_2 = (MovieTexture)Sphere2.GetComponent<Renderer>().material.mainTexture;

        video360_1.loop = true;
        video360_2.loop = true;
        video360_1.Play();
        video360_2.Play();

    }
}
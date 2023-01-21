using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{

    public Slider R,G,B;
    public GameObject camOBJ;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        camOBJ = GameObject.FindGameObjectWithTag("MainCamera");
        cam = camOBJ.GetComponent<Camera>();

        Changed();
    }

    public void Changed()
    {
        Color colour = new Color(R.value, G.value, B.value);
        cam.backgroundColor = colour;
    }
}

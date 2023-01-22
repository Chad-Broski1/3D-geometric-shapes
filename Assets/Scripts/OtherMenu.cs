using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherMenu : MonoBehaviour
{
    public Camera cam;
    public Toggle orthographicT;
    public Slider nearS, farS;

    // Start is called before the first frame update
    void Start()
    {
        Changed();
    }

    public void Changed()
    {
        cam.nearClipPlane = nearS.value;
        cam.farClipPlane = farS.value;
        cam.orthographic = orthographicT.isOn;
    }
}

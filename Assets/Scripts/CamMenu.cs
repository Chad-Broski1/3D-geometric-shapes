using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamMenu : MonoBehaviour
{

    [Range(-8,8)]
    public float camX;
    [Range(-15,15)]
    public float camY;
    [Range(-2,-25)]
    public float camZ;

    public GameObject cam;

    public Slider sX, sY, sZ;


    // Start is called before the first frame update
    void Start()
    {
        sX.value = cam.transform.position.x * -1;
        sY.value = cam.transform.position.y * -1;
        sZ.value = cam.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        camX = sX.value * -1;
        camY = sY.value * -1;
        camZ = sZ.value;

        cam.transform.position = new Vector3(camX,camY,camZ);
    }
}

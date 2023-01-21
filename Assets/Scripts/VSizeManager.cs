using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VSizeManager : MonoBehaviour
{
    public GameObject prefab;
    public Slider slider;
    public MeshManagerVert manager;

    // Start is called before the first frame update
    void Start()
    {
        Changed();
    }

    public void Changed()
    {
        prefab.transform.localScale = new Vector3(slider.value, slider.value, slider.value);

        foreach (GameObject o in manager.objs)
        {
            o.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
        }
    }
}

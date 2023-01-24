using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeManager : MonoBehaviour
{

    public bool wire = false;
    public float size = 1f, offset;
    public Slider sizeSlider;

    // Start is called before the first frame update
    void Start()
    {
        sizeSlider.value = gameObject.transform.localScale.x;
        UpdateSize();
    }

    public void UpdateSize()
    {
        offset = sizeSlider.value/180;

        if(!wire)
            size = sizeSlider.value;
        else if (wire)
            size = sizeSlider.value + offset;

        gameObject.transform.localScale = new Vector3(size, size, size);
    }
}

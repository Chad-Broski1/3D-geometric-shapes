using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourManager : MonoBehaviour
{
    [Range(1, 3)]
    public int WSV;

    public Material mat;
    public bool wire = false;

    [SerializeField]
    private Slider sliderR, sliderG, sliderB;

    // Start is called before the first frame update
    void Start()
    {
        RGB();
        ChangeColours();
    }

    public void ChangeColours()
    {
        Color color;
        color = new Color(sliderR.value, sliderG.value, sliderB.value, 1f);

        if(!wire)
            mat.SetColor("_Color", color);
        else if(wire) {
            mat.SetColor("_WireColor", color);
        }
    }

    void RGB()
    {
        if (WSV == 1)
        {
            sliderR.value = 1;
            sliderG.value = 0;
            sliderB.value = 0;
        }
        else if (WSV == 2)
        {
            sliderR.value = 0;
            sliderG.value = 1;
            sliderB.value = 0;
        }
        else if (WSV == 3)
        {
            sliderR.value = 0;
            sliderG.value = 0;
            sliderB.value = 1;
        }
    }
}

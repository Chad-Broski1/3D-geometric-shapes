using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeMenuManager : MonoBehaviour
{
    public Slider resSlider;
    public Toggle WT, ST;
    public Dropdown shapeDropdown;

    // Start is called before the first frame update
    void Start()
    {
        CheckResSlider();
        CheckWS();
    }

    public void CheckResSlider()
    {
        if (shapeDropdown.value == 1)
            resSlider.interactable = true;
        else
            resSlider.interactable = false;
    }

    public void CheckWS()
    {
        if (shapeDropdown.value == 5)
        {
            WT.interactable = false;
            ST.interactable = false;
        }
        else
        {
            WT.interactable = true;
            ST.interactable = true;
        }
    }
}

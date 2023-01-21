using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourMenuManager : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject WSliders, SSliders, VSliders;

    // Start is called before the first frame update
    void Start()
    {
        ChangeSliders();
    }

    public void ChangeSliders()
    {
        if (dropdown.value == 0)
        {
            WSliders.SetActive(true);
            SSliders.SetActive(false);
            VSliders.SetActive(false);
        }
        else if (dropdown.value == 1)
        {
            WSliders.SetActive(false);
            SSliders.SetActive(true);
            VSliders.SetActive(false);
        }
        else if (dropdown.value == 2)
        {
            WSliders.SetActive(false);
            SSliders.SetActive(false);
            VSliders.SetActive(true);
        }
    }
}

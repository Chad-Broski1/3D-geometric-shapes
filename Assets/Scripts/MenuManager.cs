using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Range(1, 3)]
    public int csc = 1;
    [SerializeField]
    private GameObject CameraLines, ShapeLines, ColourLines, CamMenu, ShaMenu, ColMenu, Panel, ShapeUI, BackgroundUI;
    public bool shapeActive = true;

    public void ShapeBackground()
    {
        if (shapeActive)
        {
            ShapeUI.SetActive(false);
            BackgroundUI.SetActive(true);
            shapeActive = false;
        }
        else if (!shapeActive)
        {
            BackgroundUI.SetActive(false);
            ShapeUI.SetActive(true);
            shapeActive = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        CameraLines.SetActive(false);
        ShapeLines.SetActive(false);
        ColourLines.SetActive(false);

        ChooseMenu();
    }

    public void ChooseMenu()
    {
        if (csc == 1)
        {
            CameraLines.SetActive(true);
            CamMenu.SetActive(true);

            ShapeLines.SetActive(false);
            ShaMenu.SetActive(false);
            ColourLines.SetActive(false);
            ColMenu.SetActive(false);
        }
        else if (csc == 2)
        {
            ShapeLines.SetActive(true);
            ShaMenu.SetActive(true);

            CameraLines.SetActive(false);
            CamMenu.SetActive(false);
            ColourLines.SetActive(false);
            ColMenu.SetActive(false);
        }
        else if (csc == 3)
        {
            ColourLines.SetActive(true);
            ColMenu.SetActive(true);

            CameraLines.SetActive(false);
            CamMenu.SetActive(false);
            ShapeLines.SetActive(false);
            ShaMenu.SetActive(false);
        }
    }

    public void Cam_p()
    {
        csc = 1;
    }

    public void Sha_p()
    {
        csc = 2;
    }

    public void Col_p()
    {
        csc = 3;
    }

    public void Minimize()
    {
        if (Panel.activeSelf)
            Panel.SetActive(false);
        else if (!Panel.activeSelf)
            Panel.SetActive(true);
    }
}

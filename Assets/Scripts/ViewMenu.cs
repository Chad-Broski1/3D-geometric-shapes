using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMenu : MonoBehaviour
{

    public GameObject camMenu, spinMenu, othMenu, rightButton, leftButton;
    [Range(1, 3)]
    public int cso = 1;

    // Start is called before the first frame update
    void Start()
    {
        Changed();
    }

    public void Right()
    {
        cso++;
        Changed();
    }

    public void Left()
    {
        cso--;
        Changed();
    }

    public void Changed()
    {
        if (cso == 1)
        {
            On(camMenu);
            Off(spinMenu);
            Off(othMenu);

            On(rightButton);
            Off(leftButton);
        }
        else if (cso == 2)
        {
            On(spinMenu);
            Off(camMenu);
            Off(othMenu);

            On(rightButton);
            On(leftButton);
        }
        else if (cso == 3)
        {
            On(othMenu);
            Off(camMenu);
            Off(spinMenu);

            On(leftButton);
            Off(rightButton);
        }
    }

    void Off(GameObject o)
    {
        o.SetActive(false);
    }

    void On(GameObject o)
    {
        o.SetActive(true);
    }
}

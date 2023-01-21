using UnityEngine;
using UnityEngine.UI;

public class SpinSpeedManager : MonoBehaviour
{
    public float Xp, Yp, Zp;
    public Slider Xs,Ys,Zs;

    void Update()
    {
        Xp += Xs.value;
        Yp += Ys.value;
        Zp += Zs.value;
    }
}

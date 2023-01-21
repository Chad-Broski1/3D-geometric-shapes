using UnityEngine;

public class SpinShape : MonoBehaviour
{
    public SpinSpeedManager manager;

    private float X, Y, Z;

    void Update()
    {
        setPos();

        transform.rotation = Quaternion.Euler(X, Y, Z);
    }

    void setPos()
    {
        X = manager.Xp;
        Y = manager.Yp;
        Z = manager.Zp;
    }
}
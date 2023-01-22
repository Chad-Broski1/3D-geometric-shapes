using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshes : MonoBehaviour
{

    private float g = (1 + Mathf.Sqrt(5)) / 2;

    //------------------------------------------Cube-----------------------------------------------------
    public Vector3[] CubeV()
    {
        return new Vector3[]
        {
            v(-.5f,-.5f,-.5f), //0
            v(-.5f,-.5f,.5f),  //1
            v(.5f,-.5f,-.5f),  //2
            v(.5f,-.5f,.5f),   //3
            v(-.5f,.5f,-.5f),  //4
            v(-.5f,.5f,.5f),   //5
            v(.5f,.5f,-.5f),   //6
            v(.5f,.5f,.5f)     //7


            // v(0,0,0), //0
            // v(0,0,1), //1
            // v(1,0,0), //2
            // v(1,0,1), //3
            // v(0,1,0), //4
            // v(0,1,1), //5
            // v(1,1,0), //6
            // v(1,1,1)  //7
        };
    }

    public int[] CubeT()
    {
        return new int[]
        {
            2,1,0,
            2,3,1,

            4,5,7,
            7,6,4,

            0,4,6,
            6,2,0,

            2,6,7,
            7,3,2,

            3,5,1,
            3,7,5,

            1,5,4,
            4,0,1
        };
    }
    //------------------------------------------Sphere---------------------------------------------------
    public Vector3[] SphereV(int samples)
    {

        List<Vector3> points = new List<Vector3>();
        float phi = Mathf.PI * (3f - Mathf.Sqrt(5f));

        for (int i = 0; i < samples; i++)
        {
            float y = 1 - (i / (float)(samples - 1)) * 2;
            float radius = Mathf.Sqrt(1 - y * y);

            float theta = phi * i;

            float x = Mathf.Cos(theta) * radius;
            float z = Mathf.Sin(theta) * radius;

            points.Add(new Vector3(x, y, z));
        }

        Vector3[] pointsA = points.ToArray();
        return pointsA;
    }

    // public Vector3[] SphereVi()
    // {
    //     return new Vector3[]
    //     {

    //     };
    // }

    public int[] SphereT()
    {
        return new int[]
        {

        };
    }
    //------------------------------------------Tetrahedron----------------------------------------------
    public Vector3[] TetrahedronV()
    {
        return new Vector3[]
        {
            v(1,0,-1/Mathf.Sqrt(2)),  //0
            v(-1,0,-1/Mathf.Sqrt(2)), //1
            v(0,1,1/Mathf.Sqrt(2)),   //2
            v(0,-1,1/Mathf.Sqrt(2))   //3
        };
    }

    public int[] TetrahedronT()
    {
        return new int[]
        {
            3,1,0,
            0,2,3,
            3,2,1,
            1,2,0
        };
    }
    //------------------------------------------Octahedron-----------------------------------------------
    public Vector3[] OctahedronV()
    {
        return new Vector3[]
        {
            v(.5f,0,0), //0
            v(-.5f,0,0),//1
            v(0,.5f,0), //2
            v(0,-.5f,0),//3
            v(0,0,.5f), //4
            v(0,0,-.5f) //5
        };
    }

    public int[] OctahedronT()
    {
        return new int[]
        {
            3,5,0,
            3,0,4,
            3,4,1,
            3,1,5,
            2,5,1,
            2,1,4,
            2,4,0,
            2,0,5
        };
    }
    //------------------------------------------Icosahedron----------------------------------------------
    public Vector3[] IcosahedronV()
    {
        return new Vector3[]
        {
            v(0,1,g),  //0
            v(0,-1,-g),//1
            v(0,-1,g), //2
            v(0,1,-g), //3
            v(1,g,0),  //4
            v(-1,-g,0),//5
            v(-1,g,0), //6
            v(1,-g,0), //7
            v(g,0,1),  //8
            v(-g,0,-1),//9
            v(-g,0,1), //10
            v(g,0,-1)  //11
        };
    }

    public int[] IcosahedronT()
    {
        return new int[]
        {
            5,1,7,
            7,2,5,
            5,2,10,
            5,10,9,
            5,9,1,
            1,11,7,
            7,11,8,
            8,2,7,
            8,0,2,
            2,0,10,
            1,9,3,
            3,11,1,
            11,4,8,
            10,6,9,
            9,6,3,
            11,3,4,
            8,4,0,
            10,0,6,
            3,6,4,
            0,4,6
        };
    }
    //------------------------------------------Dodecahedron---------------------------------------------
    public Vector3[] DodecahedronV()
    {
        return new Vector3[]
        {
            v(1,1,1),
            v(-1,-1,-1),
            v(-1,1,1),
            v(1,-1,1),
            v(1,1,-1),
            v(-1,-1,1),
            v(-1,1,-1),
            v(1,-1,-1),
            v(0,g,1/g),
            v(0,-g,-1/g),
            v(0,-g,1/g),
            v(0,g,-1/g),
            v(1/g,0,g),
            v(-1/g,0,-g),
            v(-1/g,0,g),
            v(1/g,0,-g),
            v(g,1/g,0),
            v(-g,-1/g,0),
            v(-g,1/g,0),
            v(g,-1/g,0)
        };
    }

    public int[] DodecahedronT()
    {
        return new int[]
        {

        };
    }
    //---------------------------------------------------------------------------------------------------



    Vector3 v(float x, float y, float z)
    {
        return new Vector3(x, y, z);
    }
}

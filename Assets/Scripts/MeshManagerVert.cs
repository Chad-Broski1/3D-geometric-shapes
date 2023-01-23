using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeshManagerVert : MonoBehaviour
{
    public Slider resSlider;
    public int samples = 1000;

    public Toggle wireframeT, verticesT, solidT;
    public Dropdown shapeDropdown;

    Vector3[] vertices;
    public List<GameObject> objs = new List<GameObject>();

    public GameObject spherePrefab;

    public bool active;

    public Meshes meshes;

    // Start is called before the first frame update
    void Start()
    {
        if (verticesT.isOn)
            Create();
        else
            RemoveVertices();

        ResChanged();
    }

    public void Changed()
    {
        if (verticesT.isOn)
            Create();
        else
            RemoveVertices();
    }

    public void CreateVertices()
    {
        foreach (Vector3 i in vertices)
        {
            GameObject temp = Instantiate(spherePrefab, Vector3.zero, Quaternion.identity, gameObject.transform);
            temp.transform.localPosition = i;

            objs.Add(temp);
        }
    }

    void RemoveVertices()
    {
        foreach (GameObject i in objs)
        {
            Destroy(i.gameObject);
        }
        objs.Clear();
    }

    void CreateCube()
    {
        vertices = meshes.CubeV();
        CreateVertices();
    }

    public void ResChanged()
    {
        samples = (int)resSlider.value;
        Changed();
    }

    void CreateSphere()
    {
        vertices = meshes.SphereV(samples);
        CreateVertices();
    }

    void CreateTetrahedron()
    {
        vertices = meshes.TetrahedronV();
        CreateVertices();
    }
    void CreateOctahedron()
    {
        vertices = meshes.OctahedronV();
        CreateVertices();
    }
    void CreateIcosahedron()
    {
        vertices = meshes.IcosahedronV();
        CreateVertices();
    }
    void CreateDodecahedron()
    {
        vertices = meshes.DodecahedronV();
        CreateVertices();
    }

    void Create()
    {
        RemoveVertices();
        if (shapeDropdown.value == 0)
            CreateCube();
        else if (shapeDropdown.value == 1)
            CreateSphere();
        else if (shapeDropdown.value == 2)
            CreateTetrahedron();
        else if (shapeDropdown.value == 3)
            CreateOctahedron();
        else if (shapeDropdown.value == 4)
            CreateIcosahedron();
        else if (shapeDropdown.value == 5)
            CreateDodecahedron();
        else
            RemoveVertices();
    }
}

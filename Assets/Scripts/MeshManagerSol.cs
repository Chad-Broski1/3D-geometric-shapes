using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MeshFilter))]
public class MeshManagerSol : MonoBehaviour
{
    public Toggle wireframeT, verticesT, solidT;
    public Dropdown shapeDropdown;

    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    public Meshes meshes;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        if (solidT.isOn)
            Create();

        UpdateMesh();
    }

    public void Changed()
    {
        if (solidT.isOn)
            Create();
        else
            EmptyMesh();

        UpdateMesh();
    }

    void EmptyMesh()
    {
        vertices = null;
        triangles = null;
    }

    void CreateCube()
    {
        vertices = meshes.CubeV();
        triangles = meshes.CubeT();
    }
    void CreateTetrahedron()
    {
        vertices = meshes.TetrahedronV();
        triangles = meshes.TetrahedronT();
    }
    void CreateOctahedron()
    {
        vertices = meshes.OctahedronV();
        triangles = meshes.OctahedronT();
    }
    void CreateIcosahedron()
    {
        vertices = meshes.IcosahedronV();
        triangles = meshes.IcosahedronT();
    }
    void CreateDodecahedron()
    {
        vertices = meshes.DodecahedronV();
        triangles = meshes.DodecahedronT();
    }

    void Create()
    {
        if (shapeDropdown.value == 0)
            CreateCube();
        else if (shapeDropdown.value == 2)
            CreateTetrahedron();
        else if (shapeDropdown.value == 3)
            CreateOctahedron();
        else if (shapeDropdown.value == 4)
            CreateIcosahedron();
        else if (shapeDropdown.value == 5)
            CreateDodecahedron();
        else
            EmptyMesh();

        UpdateMesh();
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    Vector3 v(float x, float y, float z)
    {
        return new Vector3(x, y, z);
    }
}

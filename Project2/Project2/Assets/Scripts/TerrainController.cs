using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{

    private Terrain terrain;

    private Vector3 terrainSize;

    public float sizeX;
    public float sizeY;
    public float sizeZ;

    void Start()
    {

        terrain = GetComponent<Terrain>();
        terrainSize = new Vector3(sizeY, sizeZ, sizeX);
        terrain.terrainData.size = terrainSize;

    }

}
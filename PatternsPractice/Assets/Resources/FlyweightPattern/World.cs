using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    private const int MAPSIZEX = 10,
                      MAPSIZEZ = 10;
    public Material red, green, blue;
    private Terrain[,] terrains = new Terrain[MAPSIZEX, MAPSIZEZ];
    private Terrain redTerrain,
                    greenTerrain,
                    blueTerrain;
    private void Start()
    {
        redTerrain = new Terrain(1, "RedTerrain", red);
        greenTerrain = new Terrain(2, "GreenTerrain", green);
        blueTerrain = new Terrain(3, "BlueTerrain", blue);
        CreateWorld();
    }
    private void CreateWorld()
    {
        for (int x = 0; x < MAPSIZEX; x++)
        {
            for (int z = 0; z < MAPSIZEZ; z++)
            {
                switch (Random.Range(0, 3))
                {
                    case 0:
                        terrains[x, z] = redTerrain;
                        break;
                    case 1:
                        terrains[x, z] = greenTerrain;
                        break;
                    case 2:
                        terrains[x, z] = blueTerrain;
                        break;
                }
                GameObject terrain = Instantiate(Resources.Load("FlyweightPattern/" + terrains[x, z].GetName(), typeof(GameObject)), transform) as GameObject;
                terrain.transform.position = new Vector3(x, 0, z);
            }
        }
    }
    public void ReCreateWorld()
    {
        foreach (Transform iter in GetComponentsInChildren<Transform>())
        {
            if (iter != transform) Destroy(iter.gameObject);
            //non-pooling
        }
        CreateWorld();
    }
    public Terrain GetTerrain(int x, int z) => terrains[x, z];
}

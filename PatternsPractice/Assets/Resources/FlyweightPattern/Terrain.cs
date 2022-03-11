using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain
{
    private readonly int cost;
    private readonly string name;
    private readonly Material material;
    public Terrain(int _cost, string _name, Material _material)
    {
        cost = _cost;
        name = _name;
        material = _material;
    }
    public string GetName() => name;
    public int GetCost() => cost;
    public Material GetMaterial() => material;
}

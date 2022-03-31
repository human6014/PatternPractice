using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebat : Unit
{
    public override void Init()
    {
        Debug.Log("Firebat Init");
    }
    public override void MoveUnit(int x, int z)
    {
        transform.Translate(new Vector3(x, 0, z));
    }
    public override void DoSomething()
    {
        //do something
    }
}

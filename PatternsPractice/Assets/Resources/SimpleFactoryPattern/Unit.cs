using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    abstract public void MoveUnit(int x, int z);
    abstract public void Init();
    abstract public void DoSomething();
}


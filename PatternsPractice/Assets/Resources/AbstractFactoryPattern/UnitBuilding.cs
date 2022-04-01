using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitBuilding : MonoBehaviour
{
    public enum Units{
        Marine,
        Medic,
        Firebat
    }
    public abstract GameObject Produce(Units units);
}

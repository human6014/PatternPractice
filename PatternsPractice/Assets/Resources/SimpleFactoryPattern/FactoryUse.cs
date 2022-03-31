using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse : MonoBehaviour
{
    Factory factory;
    List<GameObject> units = new List<GameObject>();

    private void Awake() => factory = GetComponent<Factory>();
    private void Start()
    {
        units.Add(factory.CreateUnit(UnitType.Marine));
        units.Add(factory.CreateUnit(UnitType.Medic));
        units.Add(factory.CreateUnit(UnitType.Firebat));
    }
    public void OnClicked()
    {
        int x, z = 0;
        foreach (GameObject unit in units)
        {
            x = Random.Range(-1, 2);
            z = Random.Range(-1, 2);
            unit.GetComponent<Unit>().MoveUnit(x, z);
        }
    }
}

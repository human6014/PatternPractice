using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType{
    Marine,
    Medic,
    Firebat
}
public class Factory : MonoBehaviour
{
    [SerializeField] GameObject marine;
    [SerializeField] GameObject medic;
    [SerializeField] GameObject firebat;
    public GameObject CreateUnit(UnitType _unit)
    {
        GameObject unit = null;
        float x = Random.Range(0, 6);
        float z = Random.Range(0, 6);
        switch (_unit)
        {
            case UnitType.Marine:
                unit = Instantiate(marine);
                break;
            case UnitType.Medic:
                unit = Instantiate(medic);
                break;
            case UnitType.Firebat:
                unit = Instantiate(firebat);
                break;
        }
        unit.GetComponent<Unit>().Init();
        return unit;
    }
}

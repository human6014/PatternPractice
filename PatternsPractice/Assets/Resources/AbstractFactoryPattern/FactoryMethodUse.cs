using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class FactoryMethodUse : MonoBehaviour
    {
        RootFactory rootFactory;
        List<GameObject> terranUnits = new List<GameObject>();
        private void Start()
        {
            rootFactory = GetComponent<FactoryMethod>().GetFactory(Tribe.Terran);
            
            GameObject buliding = rootFactory.CreateCapacityBuilding();
            GameObject capacity = rootFactory.CreateUnitBuilding();

            terranUnits.Add(buliding.GetComponent<UnitBuilding>().Produce(UnitBuilding.Units.Marine));
            capacity.GetComponent<RaceCapacity>().Expand();
        }
    }
}

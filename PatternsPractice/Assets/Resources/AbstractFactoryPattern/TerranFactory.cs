using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class TerranFactory : RootFactory
    {
        [SerializeField] GameObject barracks;
        [SerializeField] GameObject supplyDepot;
        public override GameObject CreateCapacityBuilding() => Instantiate(barracks, new Vector3(2,1,2), Quaternion.identity);
        public override GameObject CreateUnitBuilding() => Instantiate(supplyDepot, new Vector3(-2,1,2), Quaternion.identity);
    }
}
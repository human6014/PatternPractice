using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class ProtossFactory : RootFactory
    {
        [SerializeField] GameObject gateway;
        [SerializeField] GameObject pylon;
        public override GameObject CreateCapacityBuilding() => Instantiate(gateway, new Vector3(2,1,-2), Quaternion.identity);
        public override GameObject CreateUnitBuilding() => Instantiate(pylon, new Vector3(-2,1,-2), Quaternion.identity);
    }
}

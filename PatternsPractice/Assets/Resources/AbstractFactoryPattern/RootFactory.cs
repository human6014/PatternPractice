using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public enum Tribe
    {
        Terran,
        Protoss,
        Zerg
    }
    public abstract class RootFactory : MonoBehaviour
    {
        public abstract GameObject CreateCapacityBuilding();
        public abstract GameObject CreateUnitBuilding();
    }
}

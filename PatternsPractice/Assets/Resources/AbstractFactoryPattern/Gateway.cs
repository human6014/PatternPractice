using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Gateway : UnitBuilding
    {
        public override GameObject Produce(Units units)
        {
            Debug.Log(units);
            return null;
        }
    }
}

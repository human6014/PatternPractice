using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class Barracks : UnitBuilding
    {
        [SerializeField] GameObject marine;
        public override GameObject Produce(Units units)
        {
            GameObject unitObject = null;
            switch (units)
            {
                case Units.Marine:
                    unitObject = Instantiate(marine, new Vector3(0, 1, -3), Quaternion.identity);
                    break;
                case Units.Medic:
                    //medic
                    break;
                case Units.Firebat:
                    //firebat
                    break;
            }
            return unitObject;
        }
    }
}

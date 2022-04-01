using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern
{
    public class FactoryMethod : MonoBehaviour
    {
        public RootFactory GetFactory(Tribe type)
        {
            RootFactory factory = null;
            
            switch (type)
            {
                case Tribe.Terran:
                    factory = GetComponent<TerranFactory>();
                    break;
                case Tribe.Protoss:
                    factory = GetComponent<ProtossFactory>();
                    break;
                case Tribe.Zerg:
                    //Do Someting
                    break;
            }
            return factory;
        }
    }
}

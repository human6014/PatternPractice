using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class Enemy : Observer
    {
        public Subject subject;
        private void Start()
        {
            subject.AddObserver(this);
        }
        public override void Notify()
        {
            transform.position = new Vector3(0, 1, 3);
        }
    }
}

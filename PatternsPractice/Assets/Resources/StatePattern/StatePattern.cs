using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public abstract class StatePattern
    {
        //public abstract void EnterAction(); //Do Somting
        //public abstract void ExitAction();  //Do Somting
        public abstract void Action();
    }
    class Running : StatePattern
    {
        private Transform transform;
        public Running(Transform _transform) => transform = _transform;
        public override void Action() => transform.Translate(Vector3.forward);

        //public override void EnterAction() => throw new System.NotImplementedException();

        //public override void ExitAction() => throw new System.NotImplementedException();
    }
    class Jumping : StatePattern
    {
        private Transform transform;
        public Jumping(Transform _transform) => transform = _transform;
        public override void Action() => transform.Translate(Vector3.up);

        //public override void EnterAction() => throw new System.NotImplementedException();

        //public override void ExitAction() => throw new System.NotImplementedException();
    }
    class Sliding : StatePattern
    {
        private Transform transform;
        public Sliding(Transform _transform) => transform = _transform;
        public override void Action() =>transform.Translate(Vector3.back/2);

        //public override void EnterAction() => throw new System.NotImplementedException();

        //public override void ExitAction() => throw new System.NotImplementedException();
    }
}

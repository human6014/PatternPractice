using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class Player : Observer
    {
        [SerializeField] Subject subject;
        [SerializeField] Rigidbody rigid;
        private void Start()
        {
            subject.AddObserver(this);
        }
        private void Update()
        {
            float xMove = Input.GetAxisRaw("Horizontal");
            float zMove = Input.GetAxisRaw("Vertical");
            rigid.velocity = new Vector3(xMove * 10, 0, zMove * 10);
            if (transform.position.y < -3) subject.Notify();
        }
        public override void Notify()
        {
            transform.position = new Vector3(0, 1, 0);
            rigid.velocity = Vector3.zero;
            rigid.angularVelocity = Vector3.zero;
        }
    }
}

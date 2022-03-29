using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    ObjectPool objectPool;
    private Vector3 movement;
    public void Awake() => objectPool = FindObjectOfType<ObjectPool>();
    public void Shoot(Vector3 move)
    {
        movement = move;
        Invoke(nameof(DestoyBullet), 3);
    }
    private void DestoyBullet() => objectPool.ReturnBullet(this);
    private void Update() => transform.Translate(movement);
}

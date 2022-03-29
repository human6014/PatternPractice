using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject poolingObject;
    private Queue<Bullet> poolingObjectQueue = new Queue<Bullet>();

    private void Awake() => Initalize(50);
    private void Initalize(int count)
    {
        for (int i = 0; i < count; i++)
        {
            poolingObjectQueue.Enqueue(CreateBullet());
        }
    }
    private Bullet CreateBullet()
    {
        var bullet = Instantiate(poolingObject, transform).GetComponent<Bullet>();
        bullet.gameObject.SetActive(false);
        bullet.transform.SetParent(transform);
        return bullet;
    }
    public  Bullet GetBullet()
    {
        Bullet bullet;
        if (poolingObjectQueue.Count>0) bullet = poolingObjectQueue.Dequeue();
        else bullet = CreateBullet();
        bullet.gameObject.SetActive(true);
        bullet.transform.SetParent(null);
        return bullet;
    }
    public void ReturnBullet(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
        bullet.transform.SetParent(transform);
        poolingObjectQueue.Enqueue(bullet);
    }
    private void Update() => Debug.Log(transform.childCount);
}

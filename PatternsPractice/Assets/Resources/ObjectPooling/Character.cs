using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] ObjectPool objectPool;
    [SerializeField] GameObject bulletPrefab;
    private Camera mainCamera;
    void Start() => mainCamera = Camera.main;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit raycastHit;
            if(Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition),out raycastHit))
            {
                var movement = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z) - transform.position;
                var bullet = objectPool.GetBullet();
                bullet.transform.position = transform.position + movement.normalized;
                bullet.Shoot(movement.normalized);
            }
        }
    }
}

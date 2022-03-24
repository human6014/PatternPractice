using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    const float updateTime = 0.5f;
    const float angle = 90;
    new Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();
        StartCoroutine(nameof(RotateAct));
    }
    IEnumerator RotateAct()
    {
        while (true)
        {
            transform.Rotate(Vector3.up * angle);
            yield return new WaitForSeconds(updateTime);
        }
    }
}

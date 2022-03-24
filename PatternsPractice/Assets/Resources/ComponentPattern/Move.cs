using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    const float updateTime = 0.5f;
    const float movement = 1;
    new Transform transform;
    Vector3 move = Vector3.right;
    void Start()
    {
        transform = GetComponent<Transform>();
        StartCoroutine(nameof(MoveAct));
    }
    IEnumerator MoveAct()
    {
        while (true)
        {
            if (transform.position.x > 3) move = Vector3.left;
            else if(transform.position.x < -3)move = Vector3.right;
            transform.Translate(movement * move,Space.World);
            yield return new WaitForSeconds(updateTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform enemyTransform;
    Command rightMove, leftMove;
    void Start()
    {
        enemyTransform = GetComponent<Transform>();
        rightMove = new MoveRightCommand(enemyTransform);
        leftMove = new MoveLeftCommand(enemyTransform);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rightMove.Excute();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            leftMove.Excute();
        }
    }
}

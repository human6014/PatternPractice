using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Stack<Command> commands = new Stack<Command>();
    Transform playerTransform;
    Command rightMove, leftMove;
    bool isInverse;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (isInverse) rightMove = new MoveLeftCommand(playerTransform);
            else rightMove = new MoveRightCommand(playerTransform);
            rightMove.Excute();
            commands.Push(rightMove);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (isInverse) leftMove = new MoveRightCommand(playerTransform);
            else leftMove = new MoveLeftCommand(playerTransform);
            leftMove.Excute();
            commands.Push(leftMove);
        }
    }
    public void HorizontalInverse() => isInverse = !isInverse;
    public void UndoMove()
    {
        if (commands.Count > 0)
        {
            Command command = commands.Pop();
            command.Undo();
        }
        else Debug.LogWarning("Stack is Empty");
    }
}


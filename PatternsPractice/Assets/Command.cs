using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public Transform transform;
    public abstract void Excute();
    public abstract void Undo();
}
public class MoveRightCommand : Command
{
    private Vector3 beforePosition;
    public MoveRightCommand(Transform _transform) => transform = _transform;
    public override void Excute() => moveRight();
    public override void Undo() => transform.position = beforePosition;

    private void moveRight()
    {
        beforePosition = transform.position;
        transform.Translate(Vector3.right);
    }
}
public class MoveLeftCommand : Command
{
    private Vector3 beforePosition;
    public MoveLeftCommand(Transform _transform) => transform = _transform;
    public override void Excute() => moveLeft();
    public override void Undo() => transform.position = beforePosition;

    private void moveLeft()
    {
        beforePosition = transform.position;
        transform.Translate(Vector3.left);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster
{
    public abstract Monster Clone();
    public abstract string GetName();
}
public class Slime : Monster
{
    private string name;
    private int health,
                damage,
                speed;
    public Slime(string _name, int _health, int _damage, int _speed)
    {
        name = _name;
        health = _health;
        damage = _damage;
        speed = _speed;
    }
    public override string GetName() => name;
    public override Monster Clone() => new Slime(name, health, damage, speed);
}
public class Snail : Monster
{
    private string name;
    private int health,
                damage,
                speed;
    public Snail(string _name, int _health, int _damage, int _speed)
    {
        name = _name;
        health = _health;
        damage = _damage;
        speed = _speed;
    }
    public override string GetName() => name;
    public override Monster Clone() => new Snail(name, health, damage, speed);
}
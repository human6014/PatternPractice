using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner
{
    Monster monster;
    public Spawner(Monster _monster)
    {
        monster = _monster;
    }
    public Monster Clone()
    {
        return monster.Clone();
    }
}

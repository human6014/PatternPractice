using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    Monster slimePrototype = new Slime("Slime", 100, 10, 3);
    Monster snailPrototype = new Snail("Snail", 50, 5, 1);

    Spawner slimeSpawner;
    Spawner snailSpawner;

    void Start()
    {
        slimeSpawner = new Spawner(slimePrototype);
        snailSpawner = new Spawner(snailPrototype);
    }
    public void Spawn(string name)
    {
        Monster monster;
        
        switch (name)
        {
            case "Slime":
                monster = slimeSpawner.Clone();
                break;
            case "Snail":
                monster = snailSpawner.Clone();
                break;
            default:
                Debug.LogError("Wrong name");
                return;
        }
        GameObject monsterObject = 
            Instantiate(Resources.Load("PrototypePattern/" + monster.GetName(), typeof(GameObject)), transform) as GameObject;
        monsterObject.transform.position = new Vector3(0, 8, 0);
    }
}

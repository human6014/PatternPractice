using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScene : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    private void Start()
    {
        int num = Singleton.GetInstance().GetNum();
        for(var i = 0; i < num; i++)
        {
            Instantiate(gameObject, transform);
        }
    }
}

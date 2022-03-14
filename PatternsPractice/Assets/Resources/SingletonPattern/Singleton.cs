using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Singleton : MonoBehaviour
{
    static private Singleton singleton = null;
    static public Singleton GetInstance() => singleton;

    private int num;
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (GetInstance() != null) Destroy(gameObject);
        }
    }
    public void SetNum(int _num) => num = _num;
    public int GetNum() => num;
}

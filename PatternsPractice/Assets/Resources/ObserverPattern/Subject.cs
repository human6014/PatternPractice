using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void AddObserver(Observer o);
    void RemoveObserver(Observer o);
    void Notify();
}
public class Subject : MonoBehaviour, IObserver
{
    List<Observer> observers = new List<Observer>();
    //private delegate void NotyDelegate();  //Delegate Ver
    //NotyDelegate notyDelegate;             //Delegate Ver
    public void AddObserver(Observer o)
    {
        observers.Add(o);
        //notyDelegate += new NotyDelegate(o.Notify); //Delegate Ver
    }
    public void RemoveObserver(Observer o)
    {
        //notyDelegate -= o.Notify;          //Delegate Ver
        if (observers.Count > 0) observers.Remove(o);
    }
    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.Notify();
        }
        
        //notyDelegate();  //Delegate Ver
    }
}


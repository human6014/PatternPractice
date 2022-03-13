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
    public void AddObserver(Observer o)
    {
        observers.Add(o);
    }
    public void RemoveObserver(Observer o)
    {
        if (observers.Count > 0) observers.Remove(o);
    }
    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.Notify();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string Color { get; protected set; }
    public string Name { get; protected set; }

    protected void DisplayText(string msg)
    {
        Debug.Log(msg);
    }

    protected void DisplayText(int num)
    {
        Debug.Log($"Here's some number just to demonstrate overloading: {num}");
    }

    protected virtual void OnMouseDown()
    {
        DisplayText($"You clicked on the {Color} {Name}.");
    }
}

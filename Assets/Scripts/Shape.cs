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

    protected virtual void OnMouseDown()
    {
        DisplayText($"You clicked on the {Color} {Name}.");
    }
}

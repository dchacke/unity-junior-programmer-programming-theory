using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string Color { get; private set; }
    public string Name { get; private set; }

    void DisplayText(string msg)
    {
        Debug.Log(msg);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    public string Color { get; protected set; } // ENCAPSULATION
    public string Name { get; protected set; } // ENCAPSULATION

    [SerializeField] TextMeshProUGUI textToDisplay;

    protected void DisplayText(string msg) // ABSTRACTION
    {
        textToDisplay.text = msg;
    }

    protected void DisplayText(int num) // POLYMORPHISM
    {
        Debug.Log($"Here's some number just to demonstrate overloading: {num}");
    }

    protected virtual void OnMouseDown() // ABSTRACTION
    {
        DisplayText($"You clicked on the {Color} {Name}.");
    }
}

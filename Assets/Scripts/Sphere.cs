using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    public Sphere()
    {
        Color = "blue";
        Name = "sphere";
    }

    protected override void OnMouseDown() // POLYMORPHISM
    {
        DisplayText($"I'm a little different. You clicked on the {Color} {Name}.");
        DisplayText(1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public Sphere()
    {
        Color = "red";
        Name = "sphere";
    }

    void OnMouseDown()
    {
        DisplayText($"You clicked on the {Color} {Name}.");
    }
}

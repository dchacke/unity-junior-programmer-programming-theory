using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public Cube()
    {
        Color = "white";
        Name = "cube";
    }

    void OnMouseDown()
    {
        DisplayText($"You clicked on the {Color} {Name}.");
    }
}
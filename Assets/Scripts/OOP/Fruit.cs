/*****************************************************************************
// File Name : Fruit.cs
// Author : Luke Herron
// Creation Date : January 25, 2024
//
// Brief Description : Fruit Class that contains info (name, weight, colour)
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Fruit  //removed monobehavior
{
    //removed start and update because they inherit from monobehavior
    
    public string name;
    public string colour;
    public float weight;
    
    /// <summary>
    /// constructor for fruit class that takes 3 parameters
    /// </summary>
    /// <param name="name">name of fruit</param>
    /// <param name="c">colour of fruit</param>
    /// <param name="w">weight of fruit</param>
    public Fruit(string name, string c, float w)
    {
        this.name = name; //acts like the name of the string
        colour = c;
        weight = w;
    }

    public Fruit()
    {
        name = "banana";
        colour = "blue";
        weight = 3.7f;
    }

    public Fruit(string name)
    {
        this.name = name;
        colour = "red";
        weight = 1.0f;
    }

    public Fruit(float weight)
    {
        name = "watermelon";
        colour = "white";
        this.weight = weight;
    }

    ~Fruit()
    {
        //write to a file
        name = " ";
        colour = "clear";
        weight = 0f;
    }
}

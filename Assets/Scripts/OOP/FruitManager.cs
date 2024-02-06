using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad;

    // Start is called before the first frame update
    void Start()
    {
        fruitSalad = new List<Fruit>(); //defining the list of fruits
        
        Fruit apple = new Fruit("apple", "green", 1.2f); //defining a new fruit
        fruitSalad.Add(apple); //adds the fruit to the list

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    private void DisplayFruitSalad()
    {
        for(int i = 0; i < fruitSalad.Count; i++)
        {
            print(fruitSalad[i].colour + " " + fruitSalad[i].name + " weighs " + fruitSalad[i].weight + " units");
            //print is part of monobehavior debug is not
        }
    }

    private void CreateFruitSalad()
    {
        fruitSalad.Add(new Fruit());

        fruitSalad.Add(new Fruit("strawberry"));

        fruitSalad.Add(new Fruit(7.8f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

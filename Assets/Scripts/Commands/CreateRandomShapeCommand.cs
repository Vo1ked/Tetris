using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

public class CreateRandomShapeCommand : Command {
    private GameObject[] randomedShapes;


    public override void Execute()
    {
        var shapesContanier = GameObject.FindGameObjectWithTag("ShapesContainer").GetComponent<ShapesContainer>();
        var RandomElementsAmount = 3;
        var shapesContainerLenght = shapesContanier.Snapes.Capacity;
        for (var i = 0; i< RandomElementsAmount; i++)
        {
            var randomShapeID = Random.Range(0, shapesContainerLenght);
            shapesContanier.RandomedSnapes[i] = shapesContanier.Snapes[randomShapeID] ;
        }

    }
    }

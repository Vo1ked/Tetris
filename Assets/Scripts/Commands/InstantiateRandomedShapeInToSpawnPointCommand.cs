using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomedShapeInToSpawnPointCommand : Command {

    public override void Execute()
    {
        var shapesContatainer = GameObject.FindGameObjectWithTag("ShapesContainer").GetComponent<ShapesContainer>();
        var randomedShapes = shapesContatainer.RandomedSnapes;
        var spawnPoints = shapesContatainer.SnapesSpawnPoints;
        var scaleFactor = 0.7f;
        for (var i = 0; i< randomedShapes.Length;i++)
        {
            var Clone = Transform.Instantiate(randomedShapes[i], spawnPoints[i]);
            var pivotPosition = Clone.transform.Find("Pivot").transform.localPosition;
            var pivotMoveByScale = (pivotPosition *(1 - scaleFactor));
            Clone.transform.localPosition = Vector3.zero - (pivotPosition - pivotMoveByScale);
            Clone.transform.localScale = Vector3.one * scaleFactor;
            spawnPoints[i].GetComponent<CellInfo>().Filled = true;
        }
    }
}

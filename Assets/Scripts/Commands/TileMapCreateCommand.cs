using System.Collections;
using strange.extensions.command.impl;
using UnityEngine;

public class TileMapCreateCommand : Command {
    
    public override void Execute()
    {
        var TileMapComponent = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TileMapComponent>();
        var position = TileMapComponent.GetComponent<Transform>().position;
        var rotation = Quaternion.Euler(Vector3.zero);
        var parent = TileMapComponent.GetComponent<Transform>();
        var prefab = TileMapComponent.BlockPrefab;
        var step = TileMapComponent.StepBetweenBlocks;
        var TileMapSize = TileMapComponent.TileMapSize;

        for(var x = 0; x< TileMapSize.x; x++)
        {
            for (var y = 0; y < TileMapSize.y; y++)
            {
                var clone = GameObject.Instantiate(prefab, new Vector3(position.x + x * step, position.y + y * step,
                    position.z), rotation, parent);
                clone.GetComponent<CellInfo>().BlockID = new Vector2(x, y);
                clone.GetComponent<CellInfo>().Filled = false;
                var cloneColor = clone.GetComponent<SpriteRenderer>().color;
                clone.GetComponent<SpriteRenderer>().color = new Color(cloneColor.r,cloneColor.g,
                    cloneColor.b, 0);
            }
        }
    }
}

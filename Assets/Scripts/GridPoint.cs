using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridPoint : TileContentsController
{
    //The script for the enemies
    //Note that it inherits from TileContentsController, so it has all its variables/functions
    
    //The directions I might move
    public List<Vector2Int> Dirs = new List<Vector2Int>();

    void Start()
    {

    }
    
    //Called by GridManager after the player takes an action
    public void TakeTurn()
    {

    }

    //If I bump into something
    public override void HandleBump(TileController where, TileContentsController who)
    {
        //If I bumped into the play er. . .
        if (who is GridPlayerController)
        {

        }
    }

    //If I die, remove me from the list of enemies that exist
    private void OnDestroy()
    {
        Debug.Log("Add to score!");
    }
}

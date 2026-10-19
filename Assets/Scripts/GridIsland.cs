using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridIsland : TileContentsController
{
    //The script for the enemies
    //Note that it inherits from TileContentsController, so it has all its variables/functions

    //The directions I might move

    void Start()
    {

    }

    //My AI code for what I do on my turn
    //Called by GridManager after the player takes an action
    public void TakeTurn()
    {

    }

    //If I bump into something
    public override void HandleBump(TileController where, TileContentsController who)
    {

    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridPlayerController : TileContentsController
{
    //The script for the player
    //Note that it inherits from TileContentsController, so it has all its variables/functions
    public int energyAmount = 3;
    public bool hasEnergy = true;
    public TextMeshProUGUI energyText;

    private void Start()
    {
        energyText = 
    }

    private void Update()
    {
        if (hasEnergy)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //If I hit right, go right
                Move(1, 0);
                //And then tell the Grid Manager that I took my turn and everyone else can take theirs
                GridManager.Me.TakeTurn();
                energyAmount--;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Move(-1, 0);
                GridManager.Me.TakeTurn();
                energyAmount--;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Move(0, 1);
                GridManager.Me.TakeTurn();
                energyAmount--;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Move(0, -1);
                GridManager.Me.TakeTurn();
                energyAmount--;
            }

            string energyAmountString = energyAmount.ToString();
            energyText.text = energyAmountString;
        }

        if (energyAmount == 0)
        {
            hasEnergy = false;
            Debug.Log("GAME OVER! No Energy!");
        }
        else
        {
            hasEnergy = true;
        }
    }

    //This gets called when I walk into a non-empty tile
    public override void HandleBump(TileController where, TileContentsController who)
    {
        Debug.Log("Bumped into something!");
        //If the contents of the other tile is an island.
        if (who is GridIsland)
        {
            energyAmount = energyAmount + 5;

            SetTile(where);
        }

        if (who is GridPoint)
        {
            who.Die();
            SetTile(where);
            Debug.Log("Add to score!");
        }
    }
}

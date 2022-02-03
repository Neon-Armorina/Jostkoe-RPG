using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{

    public Sprite openedChest;
    public int Coins;
    protected override void OnCollect()
    {
        collected = true;
        GetComponent<SpriteRenderer>().sprite = openedChest;
    }
}

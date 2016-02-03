using UnityEngine;
using System.Collections;

public class Player : Actor
{


    [SerializeField]
    private int[] Inventory;



    [SerializeField]
    public override void move()
    {
        output = "Player Move";
    }

   [SerializeField]
   public void Input()
    {

    }

}

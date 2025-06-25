using UnityEngine;

public class PlayerHealth : Health
    {
    protected override void die()
    {
        base.die();
        Debug.Log("player died");
    }
    

    }

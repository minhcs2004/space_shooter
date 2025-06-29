using UnityEngine;

public class PlayerHealth : Health
    {

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public override void die()
    {
        base.die();
        Debug.Log("player died");
    }
    

    }

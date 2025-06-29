using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public GameObject hiteffect;
    private GameObject clone;
    private Vector3 effectOffset;
    

    

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (HealthPoint > 0)
        {
            effectOffset = collision.transform.position;
            clone = Instantiate(hiteffect, effectOffset, Quaternion.identity);
            Destroy(clone, 1);
            
        }
        else
        base.die();
    }

    public override void die()
    {
        base.die();
        Debug.Log("enemy died");
        enemyCouter.Instance.enemyDefeated();
    }
}

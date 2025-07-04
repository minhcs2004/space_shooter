using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public GameObject hiteffect;
    private GameObject clone;
    private Vector3 effectOffset;
    public static int livingEnemyCount;

    private void Awake()
    {
        livingEnemyCount++;
    }



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
        livingEnemyCount--;
        
        base.die();
        Debug.Log("enemy died");
        
    }
}

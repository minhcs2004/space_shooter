using UnityEngine;

public class EnemyHealth : Health
{
    public GameObject hiteffect;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (HealthPoint > 0)
        {
            Instantiate(hiteffect, transform.position, transform.rotation);
            Destroy(hiteffect, 1 / 10);
            
        }
        else
        base.OnTriggerEnter2D(collision);
    }

    protected override void die()
    {
        base.die();
        Debug.Log("enemy died");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int DefaultHealthPoint;
    protected int HealthPoint;

    protected virtual void Start()
    {
        HealthPoint = DefaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        

        if (HealthPoint <= 0) return;

        HealthPoint -= damage;
        if (HealthPoint <= 0) die();

    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
       

    }

    protected virtual void die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
        

    }

    
}

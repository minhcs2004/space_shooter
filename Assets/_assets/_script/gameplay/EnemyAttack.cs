using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth enemHealth;
    public int suicideDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(suicideDamage);
            enemHealth.die();
        }

    }


    private void Start()
    {
        if (enemHealth == null)
        {
            enemHealth = GetComponent<EnemyHealth>();
        }
    }



}
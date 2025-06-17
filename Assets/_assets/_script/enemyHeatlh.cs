using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHeatlh : MonoBehaviour
{
    public GameObject explosionPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        die();  
    }

    private void die()
    {
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

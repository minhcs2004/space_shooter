using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoshooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float firerate;
    private float fireTimer = 0;
    public Vector3 bulletOffset;
    
    void Update()
    {
        void shoot()
        {
            Instantiate(bulletPrefabs, transform.position+ bulletOffset, transform.rotation);
        }

        fireTimer += Time.deltaTime;

        if(fireTimer >= firerate)
        {
            fireTimer = 0;
            shoot();
        }
        
        


    }
}


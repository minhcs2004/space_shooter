using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float speed;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Debug.Log("Bullet hit! Damage: " + damage);
        }



        Destroy(gameObject);

    }






    // Update is called once per frame
    void Update()
    {
        var a = transform.position;
        a.y += speed * Time.deltaTime;
        transform.position = a;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCouter : MonoBehaviour
{
    public static enemyCouter Instance { get; private set; }

    public int enemyNumber = 10;
    public GameObject win;

   
    void Awake() 
    {
        if (Instance == null) 
        {
            Instance = this; 
            
        }
        else
        {
            Destroy(gameObject); 
        }

        win.SetActive(false); 
    }

    public void enemyDefeated()
    {
        enemyNumber -= 1;
        if(enemyNumber <= 0)
        {
            win.SetActive(true);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

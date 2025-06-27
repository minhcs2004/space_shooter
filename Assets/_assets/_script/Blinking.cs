using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float blinkSpeed = 0.1f;
    private float blinkTimer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        blinkTimer += Time.deltaTime;
        if(blinkTimer >= blinkSpeed)
        {
            blinkTimer = 0;
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
        
    }
}


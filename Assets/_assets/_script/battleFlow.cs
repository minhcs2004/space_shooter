using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleFlow : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject gameOverUI;
    public GameObject winUI;
    public GameObject bgMusic;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        winUI.SetActive(false);
        playerHealth.onDead += onGameOver;
        
    }

    private void onGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
    }

    private void Update()
    {
        if (EnemyHealth.livingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameWin()
    {
        winUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }

}

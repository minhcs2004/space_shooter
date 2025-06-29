using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void playButton()
    {
        SceneManager.LoadScene("battle scene");
    }

    public void returnButton()
    {
        SceneManager.LoadScene("Main menu scene");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

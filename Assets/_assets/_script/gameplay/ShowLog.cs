using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("minh dep trai"); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("minh dep trai" + Time.frameCount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitInSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("quit",4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void quit(){
        Application.Quit();
    }

}

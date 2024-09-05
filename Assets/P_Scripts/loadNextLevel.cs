using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadNextLevel : MonoBehaviour
{
    public int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        currentSceneIndex = currentScene.buildIndex;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadNextScene(){
        int ID=0;
        if(currentSceneIndex==1){
            ID=2;
        }
            if(currentSceneIndex==3){
            ID=4;
        }
                 if(currentSceneIndex==5){
            ID=6;
        }
        if(currentSceneIndex==5){
            ID=6;
        }
        SceneManager.LoadScene(ID);
    }
}

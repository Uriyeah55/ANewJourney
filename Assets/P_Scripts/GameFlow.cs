using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{

    public bool gameInProcess=false;
    public bool spawningGoodThs=true;

    public List<GameObject> spawns;
    public int pauseBetweenBadSpawns=2;
    public int pauseBetweenAnxpawns=3;

    public int pauseBetweenGoodSpawns=1;
    public GameObject badThoughtPrefab;
    public GameObject anxiousThoughtPrefab;

    public GameObject goodThoughtPrefab;
    public Canvas canvas;
    public GameObject spawnGood;
    public Sprite GT_1;
    public Sprite GT_2;
    public Sprite GT_3;
    public Sprite GT_4;
    public Sprite AT_1;
    public Sprite AT_2;
    public Sprite ST_1,ST_2,ST_3,ST_4;



    



    // Start is called before the first frame update
    void Start()
    {
     Scene currentScene = SceneManager.GetActiveScene();

        // Get the name of the active scene
        string sceneName = currentScene.name;

              // Application.OpenURL("http://unity3d.com/");

        InvokeRepeating("SpawnBadTh", 0.0f, pauseBetweenBadSpawns);
        InvokeRepeating("SpawnGoodTh", 0.0f, pauseBetweenGoodSpawns);


        if(sceneName.Equals("Level2") || sceneName.Equals("Level3")){
        InvokeRepeating("SpawnAnxiousTh", 0.0f, pauseBetweenAnxpawns);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
           if (!gameInProcess)
        {
            CancelInvoke("SpawnBadTh");
        }
    }
       GameObject GetRandomSpawn()
    {
        int randomIndex = Random.Range(0, spawns.Count);
        Debug.Log("sha triat index " + randomIndex);
        
        return spawns[randomIndex];
    }
void SpawnBadTh()
{
    if (gameInProcess)
    {
        GameObject spawnChosen = GetRandomSpawn();
        int randomSprite=Random.Range(0,4);

        // Instantiate the prefab
        GameObject copyPrefab = Instantiate(badThoughtPrefab);
         if(randomSprite==0){
            copyPrefab.gameObject.GetComponent<Image> ().sprite = ST_1;
        }
                if(randomSprite==1){
            copyPrefab.gameObject.GetComponent<Image> ().sprite = ST_2;
        }
                      if(randomSprite==2){
            copyPrefab.gameObject.GetComponent<Image> ().sprite = ST_3;
        }
                      if(randomSprite==3){
            copyPrefab.gameObject.GetComponent<Image> ().sprite = ST_4;
        }
        // Set the parent of the instantiated object to the Canvas
        copyPrefab.transform.SetParent(canvas.transform, false);

        // Convert the spawn point's world position to Canvas space
        Vector2 canvasPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, 
            Camera.main.WorldToScreenPoint(spawnChosen.transform.position), 
            Camera.main, 
            out canvasPos);

        // Set the anchored position of the RectTransform
        RectTransform rectTransform = copyPrefab.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = canvasPos;
    }
}

    
void SpawnGoodTh()
{
    if (spawningGoodThs)
    {
        int randomSprite=Random.Range(0,4);
        // Instantiate the prefab without setting the position initially
        GameObject copyGoodPrefb = Instantiate(goodThoughtPrefab);
        if(randomSprite==0){
            copyGoodPrefb.gameObject.GetComponent<Image> ().sprite = GT_1;
        }
                if(randomSprite==1){
            copyGoodPrefb.gameObject.GetComponent<Image> ().sprite = GT_2;
        }
                if(randomSprite==2){
            copyGoodPrefb.gameObject.GetComponent<Image> ().sprite = GT_3;
        }
                 if(randomSprite==3){
            copyGoodPrefb.gameObject.GetComponent<Image> ().sprite = GT_4;
        }

        // Set the parent of the instantiated object to the Canvas
        copyGoodPrefb.transform.SetParent(canvas.transform, false);

        // Convert the spawn point's world position to Canvas space
        Vector2 canvasPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, 
            Camera.main.WorldToScreenPoint(spawnGood.transform.position), 
            Camera.main, 
            out canvasPos);

        // Set the anchored position of the RectTransform to the converted position
        RectTransform rectTransform = copyGoodPrefb.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = canvasPos;
    }
}

void SpawnAnxiousTh()
{
    if (gameInProcess)
    {
        GameObject spawnChosen = GetRandomSpawn();
        int randomSprite=Random.Range(0,2);

        // Instantiate the prefab
        GameObject copyPrefab = Instantiate(anxiousThoughtPrefab);

    if(randomSprite==0){
            copyPrefab.gameObject.GetComponent<Image> ().sprite = AT_1;
        }
                if(randomSprite==1){
            copyPrefab.gameObject.GetComponent<Image> ().sprite = AT_2;
        }

        // Set the parent of the instantiated object to the Canvas
        copyPrefab.transform.SetParent(canvas.transform, false);

        // Convert the spawn point's world position to Canvas space
        Vector2 canvasPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, 
            Camera.main.WorldToScreenPoint(spawnChosen.transform.position), 
            Camera.main, 
            out canvasPos);

        // Set the anchored position of the RectTransform
        RectTransform rectTransform = copyPrefab.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = canvasPos;
    }
}


}

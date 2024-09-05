using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBossThought : MonoBehaviour
{
       public GameObject bossPrefab;
    public GameObject spawnBoss;
    public int delaySpawn=1;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnBossTh",delaySpawn);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
void spawnBossTh()
{

    this.gameObject.GetComponent<AudioSource>().Play();
    // Instantiate the boss prefab without setting the position initially
    GameObject copyBossPrefab = Instantiate(bossPrefab);

    // Set the parent of the instantiated object to the Canvas
    copyBossPrefab.transform.SetParent(canvas.transform, false);

    // Convert the spawn point's world position to Canvas space
    Vector2 canvasPos;
    RectTransformUtility.ScreenPointToLocalPointInRectangle(
        canvas.transform as RectTransform, 
        Camera.main.WorldToScreenPoint(spawnBoss.transform.position), 
        Camera.main, 
        out canvasPos);

    // Set the anchored position of the RectTransform to the converted position
    RectTransform rectTransform = copyBossPrefab.GetComponent<RectTransform>();
    rectTransform.anchoredPosition = canvasPos;
}

}

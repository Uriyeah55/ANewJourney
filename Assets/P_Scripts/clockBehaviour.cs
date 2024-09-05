using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class clockBehaviour : MonoBehaviour
{
    public GameObject endPosition;
    public GameObject gameFlowManager;

    public float speed =1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, endPosition.transform.position, speed);
    }
  void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "endLevelTrigger")
    {
        //manager.GetComponent<WindowResizer>().OnWrongChoice();
        GetComponent<loadNextLevel>().loadNextScene();

    }
}}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class thoughtBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject manager;
    public float speed=.7f;
    int currentCursor;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("/Manager");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed);
        currentCursor=manager.GetComponent<ToolsChange>().currentMouseSelected;
/*
            if (Input.GetMouseButtonDown(1))
            {
            Debug.Log("Pressed on bad th. current cursor: " + currentCursor);
            if(currentCursor==1){
            manager.GetComponent<WindowResizer>().OnWrongChoice();
            Destroy(this.gameObject, 0f); 
            }

         }
         */
    }
  void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "Player")
    {
        manager.GetComponent<WindowResizer>().OnWrongChoice();
        Destroy(gameObject, 0f); 
    }
}

}

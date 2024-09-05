using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoodThBehaviour : MonoBehaviour
{
    public GameObject endRoutePoint;
    public GameObject manager;
    public float speed=.5f;
    int currentCursor;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("/Manager");
        endRoutePoint = GameObject.FindGameObjectWithTag("GoodThRouteEnd");

    }

    // Update is called once per frame
    void Update()
    {
        currentCursor=manager.GetComponent<ToolsChange>().currentMouseSelected;
        transform.position = Vector2.MoveTowards(transform.position, endRoutePoint.transform.position, speed);
        /*
         if (Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed left-click.");
            if(currentCursor==0){
            manager.GetComponent<WindowResizer>().OnCorrectChoice();
            Destroy(this.gameObject, 0f); 
            }

         }
         */
    }
  void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "GoodThRouteEnd")
    {
        Destroy(gameObject, 0f); 
    }
}

}

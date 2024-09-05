using UnityEngine;

public class AccelerateClock : MonoBehaviour
{
    private GameObject canvas;
    private GameObject clock;

    void Start()
    {
        // Locate the Canvas in the scene
        canvas = GameObject.Find("Canvas");
   
    }
    public void AccelerateSpeedClock(){
            clock = canvas.transform.Find("Clock")?.gameObject;
            clock.GetComponent<clockBehaviour>().speed += .5f;
    }
}

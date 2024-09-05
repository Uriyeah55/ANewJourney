using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDestroy : MonoBehaviour, IPointerClickHandler
{
    int currentCursor;
    public GameObject manager;


    void Start()
    {
        manager = GameObject.Find("/Manager");

    }
void Update(){
        currentCursor=manager.GetComponent<ToolsChange>().currentMouseSelected;

}
    public void OnPointerClick(PointerEventData eventData)
    {
           if(currentCursor==0 && this.gameObject.tag=="Good"){
                manager.GetComponent<WindowResizer>().OnCorrectChoice();
                GameObject.Destroy(gameObject);
            }
            if(currentCursor==1 && this.gameObject.tag=="Bad"){
                manager.GetComponent<WindowResizer>().OnCorrectChoice();
                GameObject.Destroy(gameObject);
            }
                if(currentCursor==2 && this.gameObject.tag=="Anxious"){
                this.gameObject.GetComponent<AccelerateClock>().AccelerateSpeedClock();
                GameObject.Destroy(gameObject);
            }
    }

}
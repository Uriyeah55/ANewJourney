using UnityEngine;
using UnityEngine.UI;


public class GameLogic : MonoBehaviour
{
    public WindowResizer windowResizer;
    public Text textS;

void Awake(){
    windowResizer=GetComponent<WindowResizer>();
}
void Start(){
}
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            windowResizer.OnCorrectChoice();
        }
         if (Input.GetKeyDown(KeyCode.Space))
        {
            windowResizer.OnWrongChoice();
        }
        */
    }
}

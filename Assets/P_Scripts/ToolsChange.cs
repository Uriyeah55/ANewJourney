using UnityEngine;
using UnityEngine.UI; 

public class ToolsChange : MonoBehaviour
{
    public int currentMouseSelected;
    public Texture2D heartMouse; 
    public Texture2D scissorsMouse; 
    public Texture2D journalMouse; 


    public Vector2 hotSpot = Vector2.zero; // The point within the cursor image that will be the actual cursor position
    public CursorMode cursorMode = CursorMode.Auto; // The mode of the cursor

    void Start()
    {
        // Optionally, you can set the default cursor here or in the inspector
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); // Reset to default
    }

void Update(){
  
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            ChangeCursorToHeart(); 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            ChangeCursorToScissors();
        }
                if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            ChangeCursorToJournal();
        }
}
    public void ChangeCursorToHeart()
    {
        Cursor.SetCursor(heartMouse, hotSpot, cursorMode);
        currentMouseSelected=0;
    }
        public void ChangeCursorToScissors()
    {
        Cursor.SetCursor(scissorsMouse, hotSpot, cursorMode);
        currentMouseSelected=1;
    }
            public void ChangeCursorToJournal()
    {
        Cursor.SetCursor(journalMouse, hotSpot, cursorMode);
        currentMouseSelected=2;
    }
}

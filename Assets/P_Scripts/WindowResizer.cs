using UnityEngine;

public class WindowResizer : MonoBehaviour
{
    public int minWidth = 400;
    public int minHeight = 300;
    public int maxWidth = 1920;
    public int maxHeight = 1080;
    public int resizeStep = 100; // How much to resize per correct/wrong choice

    private int currentWidth;
    private int currentHeight;

    void Start()
    {
        // Initialize with the current screen resolution
        currentWidth = Screen.width;
        currentHeight = Screen.height;
    }

    public void OnCorrectChoice()
    {
        Debug.Log("good choice");

        // Increase window size
        ResizeWindow(currentWidth + resizeStep, currentHeight + resizeStep);
    }

    public void OnWrongChoice()
    {
        // Decrease window size
        Debug.Log("wrong choice");
        ResizeWindow(currentWidth - resizeStep, currentHeight - resizeStep);
    }

    private void ResizeWindow(int width, int height)
    {
        // Clamp the size between the minimum and maximum values
        currentWidth = Mathf.Clamp(width, minWidth, maxWidth);
        currentHeight = Mathf.Clamp(height, minHeight, maxHeight);

        // Apply the new resolution
        Screen.SetResolution(currentWidth, currentHeight, false);
    }
}

using UnityEngine;

public class SetWindowFull : MonoBehaviour
{
    public int maxWidth = 1920;
    public int maxHeight = 1080;

    private int currentWidth;
    private int currentHeight;

    void Start()
    {
        // Initialize with the specified resolution
        currentWidth = maxWidth;
        currentHeight = maxHeight;

        // Set the resolution to the desired width and height in windowed mode
        Screen.SetResolution(currentWidth, currentHeight, FullScreenMode.Windowed);
    }
}

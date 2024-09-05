using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed = 100f; // Speed at which the image will move
    public float leapDistance=200f;
    private RectTransform rectTransform;

    void Start()
    {
        // Get the RectTransform component of the UI element
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Move the image to the right by modifying the anchoredPosition
        rectTransform.anchoredPosition += Vector2.right * speed * Time.deltaTime;
    }
        void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("colisio");
        if (other.gameObject.tag == "ResetRoute")
        {
        Debug.Log("teleport en teoria");

        rectTransform.anchoredPosition += Vector2.left * leapDistance;

        }
    }
}

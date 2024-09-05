using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BossBehaviour : MonoBehaviour
{
    public GameObject player,manager;
    public Sprite newSprite,secondSprite,thirdSprite,foxHappy;
    private bool isMoving = true;

    public float speed = 0.2f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.Find("/Manager");

    }

    void Update()
    {
        // Only move the object if isMoving is true
        if (isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.GetComponent<AudioSource>().Stop();
            Debug.Log("Touched the player");
            isMoving = false; // Stop the movement
            Invoke("next",4f);
        }
    }
    void next(){
this.gameObject.GetComponent<Image> ().sprite = newSprite;
            Invoke("secondChange",3f);
player.gameObject.GetComponentInChildren<Image> ().sprite = foxHappy;


    }
        void secondChange(){
this.gameObject.GetComponent<Image> ().sprite = secondSprite;
            Invoke("thirdChange",3f);


    }
            void thirdChange(){
this.gameObject.GetComponent<Image> ().sprite = thirdSprite;
            Invoke("LoadEnding",3f);


    }

    void LoadEnding(){
        SceneManager.LoadScene(8);

    }

}

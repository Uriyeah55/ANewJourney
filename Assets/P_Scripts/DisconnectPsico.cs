using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisconnectPsico : MonoBehaviour
{
    public GameObject manager;
    public GameObject psico;
    public GameObject psicoDC;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("/Manager");
     Invoke("turnOffPsico", 6f);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void turnOffPsico()
{
        manager.GetComponent<GameFlow>().spawningGoodThs=false;
        psico.GetComponent<Animator>().SetTrigger("disconnect");
        psico.gameObject.GetComponent<AudioSource>().Play();
        Invoke("xaparAudio", 3f);

}
 void xaparAudio(){
    psico.gameObject.GetComponent<AudioSource>().Stop();

}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroSequence : MonoBehaviour
{
    public GameObject text1;

    public GameObject BG,cartell;
    public GameObject nuvol1,nuvol2;

    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject Btn1;
    public GameObject Btn2;
    public GameObject Btn3;




    public GameObject foxi;

    public GameObject foxShe;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnBG",2f);
        Invoke("spawnFox",3f);
        Invoke("spawnFoxShe",4f);
        Invoke("showText1",5f);
        Invoke("showText2",8f);
        Invoke("showText3",10f);
        Invoke("showText4",12f);
        Invoke("showText5",15f);

        Invoke("showBotons",17f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnBG(){
        BG.SetActive(true);
    }
     public void spawnFox(){
        foxi.SetActive(true);
    }
     public void spawnFoxShe(){
        foxShe.SetActive(true);
    }
         public void showText1(){
        text1.SetActive(true);
    }
             public void showText2(){
        text2.SetActive(true);

    }
             public void showText3(){
        text3.SetActive(true);
        //aqui
        foxShe.GetComponent<Animator>().SetTrigger("disap");
        cartell.SetActive(true);


    }
                 public void showText4(){
        text4.SetActive(true);
    }
                     public void showText5(){
        text5.SetActive(true);
    }
        public void showBotons()
        {
            Btn1.SetActive(true);
            Btn2.SetActive(true);
            Btn3.SetActive(true);

            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            nuvol1.SetActive(true);
            nuvol2.SetActive(true);
            foxi.GetComponent<Animator>().SetTrigger("idle");


        }
}

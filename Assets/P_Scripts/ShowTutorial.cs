using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    public GameObject panelTuto;
            public GameObject fox;

            public GameObject Btn1;
    public GameObject Btn2;
    public GameObject Btn3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayPanel(){
        panelTuto.SetActive(true);
        fox.SetActive(false);

        Btn1.SetActive(false);
Btn2.SetActive(false);
Btn3.SetActive(false);
    }
}

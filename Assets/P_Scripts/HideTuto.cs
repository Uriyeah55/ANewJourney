using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTuto : MonoBehaviour
{
        public GameObject fox;
    public GameObject Btn2;
    public GameObject Btn1;

    public GameObject Btn3;
    public GameObject PanelTuto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void hideTutorial(){
Btn1.SetActive(true);
fox.SetActive(true);

Btn2.SetActive(true);
Btn3.SetActive(true);
PanelTuto.SetActive(false);


    }
}

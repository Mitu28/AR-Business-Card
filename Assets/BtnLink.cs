using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class BtnLink : MonoBehaviour,IVirtualButtonEventHandler
{

  //  public GameObject LnkBtn;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("https://www.linkedin.com/feed/");
    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }



}

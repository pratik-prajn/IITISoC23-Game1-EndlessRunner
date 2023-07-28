using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableUI : MonoBehaviour
{
    public GameObject messageUI;
    public bool donevalue=false;
    powerupmessage pm;
    public GameObject mn;

     void Start() 
    {
        
        pm = mn.GetComponent<powerupmessage>();
    }
    void Update() 
    {
        if (pm.done==true)
        {
            messageUI.SetActive(true);
        }
        else{
            messageUI.SetActive(false);
        }
        
    }
    // Update is called once per frame
      
}

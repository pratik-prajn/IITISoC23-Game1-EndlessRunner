using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pp : MonoBehaviour


{
    public bool done=false;
    public GameObject ps;
   
  
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (done==true)
        {
            Instantiate(ps,transform.position,transform.rotation);
            
            done=false;
        }
    }
}

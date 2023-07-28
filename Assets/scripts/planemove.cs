using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planemove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardspeed=200f;
    
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
       rb.AddForce(0,0,forwardspeed);
    }
}

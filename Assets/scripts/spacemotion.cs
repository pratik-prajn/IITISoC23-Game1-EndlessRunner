using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacemotion : MonoBehaviour
{
    private Rigidbody rb;
   
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject rightrotation;
    [SerializeField] private GameObject leftrotation;
    [SerializeField] private float smoothtime=0.3f;
    [SerializeField] private float smoothtimemiddle=0.3f;
    [SerializeField] private float turnspeed =100f;
    [SerializeField] private float forwardspeed=200f;


    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    
    private void FixedUpdate()
    {
        
        var xx =Input.GetAxis("Horizontal");
        rb.velocity=new Vector3(xx*turnspeed*Time.deltaTime,0f,-forwardspeed*Time.deltaTime);



        if (xx<0)
        { 
            
            
            player.transform.rotation=Quaternion.Slerp(player.transform.rotation,leftrotation.transform.rotation,smoothtime);
            
        }

        if (xx==0)
        {
            player.transform.rotation=Quaternion.Slerp(player.transform.rotation,transform.rotation,smoothtimemiddle);
            
        }

        if (xx>0)
        {
          
            player.transform.rotation=Quaternion.Slerp(player.transform.rotation,rightrotation.transform.rotation,smoothtime);
            
        }
    }
}

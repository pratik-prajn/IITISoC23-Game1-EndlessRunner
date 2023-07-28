using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrotate : MonoBehaviour
{

    public Camera cam;
    public float smoothtime=0.3f;
    [SerializeField] private float smoothtimemiddle=0.3f;
    [SerializeField] private GameObject rightrotation;
   
    [SerializeField] private GameObject leftrotation;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void FixedUpdate()
    {
        var xx =Input.GetAxis("Horizontal");
        if (xx<0)
        { 
            cam.transform.rotation=Quaternion.Slerp(cam.transform.rotation,leftrotation.transform.rotation,smoothtime);
        }

        if (xx==0)
        {
            cam.transform.rotation=Quaternion.Slerp(cam.transform.rotation,transform.rotation,smoothtimemiddle);
        }

        if (xx>0)
        {
            cam.transform.rotation=Quaternion.Slerp(cam.transform.rotation,rightrotation.transform.rotation,smoothtime);
        }
        
    }
}

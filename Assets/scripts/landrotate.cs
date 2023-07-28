using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landrotate : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject rightrotation;
    [SerializeField] private GameObject leftrotation;
    [SerializeField] private float smoothtime=0.3f;
    [SerializeField] private float smoothtimemiddle=0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var xx =Input.GetAxis("Horizontal");
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

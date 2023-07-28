using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public float turnspeed=90f;

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.name!="Player")
        {
            return;
        }

        Destroy(gameObject);
        
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,turnspeed*Time.deltaTime,0);
    }
}

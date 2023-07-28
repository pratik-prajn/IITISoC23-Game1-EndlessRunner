using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerupmessage : MonoBehaviour
{

    public float duration=7f;
   
    public bool done=false;
    public GameObject boatm;
    public GameObject scorem;
  

   




    void Start() 
    {
        boatm=GameObject.Find("Boat");
        scorem=GameObject.Find("spawner");
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine (Pickup(other));
        }
    }

    IEnumerator  Pickup(Collider other)
    {
        done=true;
       
        GetComponent<MeshRenderer>().enabled=false;
        GetComponent<Collider>().enabled=false;
        boatm.GetComponent<Collider>().enabled=false;
        scorem.GetComponent<Collider>().enabled=false;
      
        Debug.Log("Picked up");
       
        Debug.Log(done);
        
     

        yield return new WaitForSeconds(duration);
        done=false;
        boatm.GetComponent<Collider>().enabled=true;
        scorem.GetComponent<Collider>().enabled=true;
      
        Destroy(gameObject);
        Debug.Log(done);
    }
}

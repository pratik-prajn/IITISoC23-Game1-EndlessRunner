using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float TimeLeft = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
 void Update() {
      TimeLeft -= Time.deltaTime;
      if ( TimeLeft < 0 )
      {
          Destroy(gameObject);
      }
/*if ( player.transform.position.z >gameObject.transform.position.z )
      {
          Destroy(gameObject);
      }*/

 }
}

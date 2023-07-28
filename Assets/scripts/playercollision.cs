using UnityEngine;
using UnityEngine.UI;

public class playercollision : MonoBehaviour
{
    public spacemotion sp;
    public score sc;
    public GameManager gameManager;
    
    
    private bool dead;
     void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.collider.tag=="obs" && !dead)
       {
        Debug.Log("we hit it");
        sp.enabled=false;
        sc.enabled=false;
        dead=true;

       gameManager.GameOver();
        
        
       }
    }
}

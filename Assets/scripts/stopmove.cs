using UnityEngine;
using UnityEngine.UI;

public class stopmove : MonoBehaviour
{
    public spacemotion sp;

    /*public GameManager gameManager;
    */
    
    private bool dead;
     void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.collider.tag=="obs" && !dead)
       {
        Debug.Log("we hit it");
        sp.enabled=false;
        
        dead=true;
       /* gameManager.GameOver();*/
        
        
       }
    }
}

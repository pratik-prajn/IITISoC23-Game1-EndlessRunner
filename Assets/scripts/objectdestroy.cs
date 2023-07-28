using UnityEngine;

public class objectdestroy : MonoBehaviour
{

    public GameObject player;
    public GameObject objects;
    public  ItemAreaSpawner xx;


    //public ItemAreaSpawner spawnnum;
    void Start()
    {
        //spawnnum=FindObjectOfType<ItemAreaSpawner>();
    }
    // Update is called once per frame
    void Update()
    {
        /*if (player.transform.position.z>objects.transform.position.z)
        {
        
             Destroy(objects, 1f);
             xx.i--;
            
        }*/
    }
}

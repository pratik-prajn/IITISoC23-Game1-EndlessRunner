using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAreaSpawner : MonoBehaviour
{
    public GameObject itemToSpread;
    public int numItemsToSpawn = 10;
    public GameObject player;
    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;
    public int objno=0;
    
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void SpreadItem()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
       GameObject clone = Instantiate(itemToSpread, randPosition, itemToSpread.transform.rotation);
       if (player.transform.position.z >clone.transform.position.z)
       {
        Destroy(clone,1f);
       }
    }


void Update()
{
    objno=GameObject.FindGameObjectsWithTag("obs").Length;
    Debug.Log(objno);
    for (objno = 0; objno < numItemsToSpawn; objno++)
        {
            SpreadItem();
        }
    
}

}
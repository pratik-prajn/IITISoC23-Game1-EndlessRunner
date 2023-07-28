using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject spawnItem;
   
    public float frequency;
    public float initialSpeed;
    public float lastspawnTime;
    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;

    void Update() 
    {
        if (Time.time >lastspawnTime+frequency)
        {
            Spawn();
            lastspawnTime=Time.time;
        }
        
        
    }
    public void Spawn()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(0, itemZSpread)+150) + transform.position;
        GameObject newspawnitem=Instantiate(spawnItem,randPosition,Quaternion.identity);

        

    }

}

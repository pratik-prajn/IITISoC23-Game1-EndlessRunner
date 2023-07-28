using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 500;
    public int totalNumOfTiles = 8;
    public int numberOfTiles = 3;
    public Transform playerTransform;
    private List<GameObject> activeTiles = new List<GameObject>();
    public GameObject coinsprefab;

    void Start()
    {
      for (int i = 0; i < numberOfTiles; i++)
        {
            if(i==0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z-550>zSpawn-(numberOfTiles*tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

    public void SpawnTile(int tileIndex)
    {
        Vector3 randomspawnPosition=new Vector3(0,-5,zSpawn);
        GameObject go= Instantiate(tilePrefabs[tileIndex],randomspawnPosition,transform.rotation);

        activeTiles.Add(go);
        zSpawn+=tileLength;
    } 


    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    void coinspawn()
    {
        int coinstospawn=10;
        for (int i=0;i<coinstospawn;i++){
           GameObject temp = Instantiate(coinsprefab);
           temp.transform.position=g(GetComponent<Collider>());
        }
    }

    Vector3 g(Collider collider)
    {
        Vector3 point = new Vector3(
        Random.Range(collider.bounds.min.x,collider.bounds.max.x),
        Random.Range(collider.bounds.min.y,collider.bounds.max.y),
        Random.Range(collider.bounds.min.z,collider.bounds.max.z));

        point.y=1;
        return point;
    }
}

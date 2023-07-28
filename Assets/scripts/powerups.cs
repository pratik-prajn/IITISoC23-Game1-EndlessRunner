using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{

    public float duration=4f;
 void OnTriggerEnter(Collider other)
 {
    if (other.CompareTag("Player"))
    {
        StartCoroutine (Pickup(other));
    }
 }

 IEnumerator  Pickup(Collider other)
 {
    GetComponent<MeshRenderer>().enabled=false;
    GetComponent<Collider>().enabled=false;
    Debug.Log("Picked up");
    Time.timeScale=1.5f;
    yield return new WaitForSeconds(duration);
    Time.timeScale=1f;
    Destroy(gameObject);
 }
}

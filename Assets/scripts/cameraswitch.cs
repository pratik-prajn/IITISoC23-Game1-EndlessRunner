using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
{

    public GameObject camPlane;
    public GameObject camBoat;
    public MeshRenderer planeMesh;
    public Collider planeCollider;
    public MeshRenderer boatMesh;
    public Collider boatCollider;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            camBoat.SetActive(false);
            camPlane.SetActive(true);
            planeMesh.enabled=true;
            planeCollider.enabled=true;
            boatMesh.enabled=false;
            boatCollider.enabled=false;
            Debug.Log("plane");
        }

          if (Input.GetKeyDown(KeyCode.E))
        {
            camBoat.SetActive(true);
            camPlane.SetActive(false);
            planeMesh.enabled=false;
            planeCollider.enabled=false;
            boatMesh.enabled=true;
            boatCollider.enabled=true;
            Debug.Log("boat");
        }

       /* if (Input.GetKeyDown(KeyCode.Escape))
        {
            camBoat.SetActive(false);
            camPlane.SetActive(true);
            planeMesh.enabled=true;
            boatMesh.enabled=false;
            Debug.Log("pause");
        }*/
    }
}

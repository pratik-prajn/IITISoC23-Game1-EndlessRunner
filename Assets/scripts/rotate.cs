using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] private Vector3 rotation1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation1*Time.deltaTime);
    }
}

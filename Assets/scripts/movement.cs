using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ff=50f;
    public float sf=10f;



    void FixedUpdate()
    {
        rb.AddForce(0,0,-ff*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(-sf*Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(sf*Time.deltaTime,0,0);
        }
    }
}

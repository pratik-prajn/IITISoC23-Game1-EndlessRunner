using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{

    
    private Renderer rend;

    
   
    [SerializeField] float _interval = 3f;
    float _time;
    // Use this for initialization
    private void Start () 
    {

        

       // Get the Renderer component from the new cube
       rend = GetComponent<Renderer>();

        // Create a new RGBA color using the Color constructor and store it in a variable
       
    

        _time = 0f;

       // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
       
       
    }

    void color_change()
    {
        Color[] colors = { new Color32(136, 236, 117, 255), new Color32(248, 183, 102, 255), new Color32(255,132,131, 255), new Color32(231, 134, 157, 255) };
        rend.material.SetColor("_Color", colors[Random.Range(0,colors.Length)]);
    }	

     void FixedUpdate() {

        _time += Time.deltaTime;
    while(_time >= _interval) {
      color_change();
      _time -= _interval;
        
    }
}}
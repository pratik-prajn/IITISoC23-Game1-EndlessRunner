using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Quit()
 {
    Debug.Log("Quit");
    Application.Quit();
 }
     public void Startgame()
 {
    SceneManager.LoadScene("Game");
    Debug.Log("AAAAA");
 }
     public void Credits()
 {
    SceneManager.LoadScene("credits");
    Debug.Log("AAAAA");
 }

 public void hp()
 {
    SceneManager.LoadScene("howtoplay");
    Debug.Log("AAAAA");
 }
}

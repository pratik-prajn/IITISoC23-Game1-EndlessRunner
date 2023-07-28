using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    /*public Text pointText;
 public void Setup(int score)
 {
    gameObject.SetActive(true);
    pointText.text=score.ToString();
 }*/

 public void Quit()
 {
    Debug.Log("Quit");
    Application.Quit();
 }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class randomquote : MonoBehaviour
{
    public GameObject quotepanel;
    /*public Gameobject gameoverPanel;
    string[] quote = new string[] {"Matt", "Joanne", "Robert"};
    public Text currentquote;
    public int textIndex;*/

    void Start()
    {
       
        EnableGamePanel();
    }

    IEnumerator EnableGamePanel()
    {
        yield return new     WaitForSeconds(5);
        Debug.Log("DOne");
        quotepanel.SetActive(true);
    }

    
}

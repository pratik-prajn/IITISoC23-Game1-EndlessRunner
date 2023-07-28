using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour
{
    public Transform character;
    public List<Transform> possibleCharacter;
    public int whichCharacter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (whichCharacter==0)
            {
                whichCharacter=possibleCharacter.Count-1;
            }
            else{
                whichCharacter-=1;
            }
            Swapz();
        }
         if (Input.GetKeyDown(KeyCode.E))
        {
              if (whichCharacter==possibleCharacter.Count-1)
            {
                whichCharacter=0;
            }
            else{
                whichCharacter+=1;
            }
            Swapz();
        }


    }

    public void Swapz()
    {
        character=possibleCharacter[whichCharacter];
        /*character.GetComponent<spacemotion>*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[] playerNames = new string[] {"Bob","Lia","Carrie","Jack"};
    int i=0;
    int[] randomNumbers = new int[3];

    // Start is called before the first frame update
    private void Start(){
        {
            print(playerNames[0]);
            while(i<playerNames.Length){
                print(playerNames[i]);
                i++;
            }

            for (int i=0; i<randomNumbers.Length; i++){
                randomNumbers[i]=Random.Range(0,100);
                print(randomNumbers[i]);
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

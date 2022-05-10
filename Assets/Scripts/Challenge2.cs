using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{
    string[] words =new string[] {"hi","my","name","is","Chaeil"};

    // Start is called before the first frame update
    void Start()
    {
        void PrintReverse(string[] arr){
            for (int i=arr.Length-1; i>=0; i--){
                print(arr[i]);
            }
            
        PrintReverse(words);
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

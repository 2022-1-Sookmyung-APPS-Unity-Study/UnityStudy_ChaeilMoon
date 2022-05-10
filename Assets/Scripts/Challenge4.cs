using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge4 : MonoBehaviour
{
    string[] greet=new string[] {"hi","hello","bye"};

    // Start is called before the first frame update
    void Start()
    {

        bool IsUniform(string[] arr){
            bool result=true;
            for(int i=1; i<arr.Length; i++){
                if(arr[0] != arr[i]){
                    result=false;
                }
            }
            return result;
        }

        print(IsUniform(greet));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

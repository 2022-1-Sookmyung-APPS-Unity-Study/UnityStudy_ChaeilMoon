using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3 : MonoBehaviour
{
    int[] maximus=new int[] {2,4,8};


    // Start is called before the first frame update
    void Start()
    {
        int Max(int[] arr){
            int max=arr[0];
            for(int i=0; i<=arr.Length-1; i++){
                if (arr[i]>=max){
                    max=arr[i];
                }
            }
            return max;
        }
        print(Max(maximus));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge1 : MonoBehaviour
{
    int[] numbers= new int[]{34,17,6};

    // Start is called before the first frame update
    void Start()
    {

    //1.SumArray

        int SumArray(int[] arr){
            int result=0;
            for (int i=0; i<arr.Length; i++){
                result+=arr[i];
            }
            return result;
        }

        print(SumArray(numbers));




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    int k=10;
    int t=1;

    // Start is called before the first frame update
    void Start()
    { //1. Print all numbers between -5 and 5
        for(int i=-5; i<=5; i++){
            print(i);
        }
      //2. Print all even numbers between 10 and 50  
        while (k<=50){
            print(k);
            k+=2;
        }
     //3. Print numbers divided by 3 and 5 between 1 to 100
        
        while (t<=100){
            if(t%3==0 && t%5 ==0) {
                print(t);
            }
            t++;
            }
        

        


    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

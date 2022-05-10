using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1. IsEven
        bool IsEven(int i){
            if(i%2==0){
                return true;
            } else {
                return false;
            }
        }
        //2. WhatIsBigger
        int WhatIsBigger(int a, int b){
            if (a>=b){
                return a;
            }else{
                return b;
            }
        }
        //3. Repeat
        void Repeat(string k, int a){
            for(int i=1; i<=a; i++){
                print(k);
            }
        }
        //4. Factorial
        int Factorial(int n){
            int result =1;
            for(int i=1;i<=n;i++){
                result*=i;
            }

            return result;
        }

        print(IsEven(4));
        print(WhatIsBigger(52,74));
        Repeat("hello", 5);
        print(Factorial(4));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

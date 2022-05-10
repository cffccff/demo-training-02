using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour

{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");


        // display value of num
        int num = 100;
        num = 400;
        Debug.Log(num);


        //display value of j after calculate
        int i = 100;

        int j = i + 20; // j = 120

        i = 200;
        j = i + 20;// j = 220

        i = 300;
        Debug.Log(j);


        //Conversions
        int i1 = 345;
        float f = i1;

        Debug.Log(f);


        //convert string to time
        var str = "5/12/2020";
        System.DateTime dt;

        var isValidDate = System.DateTime.TryParse(str, out dt);
        Debug.Log(str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

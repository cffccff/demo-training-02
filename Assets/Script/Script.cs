using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class Script : MonoBehaviour

{
   
    // Start is called before the first frame update
    void Start()
    {
        //Tuesday


        //Debug.Log("Hello World");


        //// display value of num
        //int num = 100;
        //num = 400;
        //Debug.Log(num);


        ////display value of j after calculate
        //int i = 100;

        //int j = i + 20; // j = 120

        //i = 200;
        //j = i + 20;// j = 220

        //i = 300;
        //Debug.Log(j);


        ////Conversions
        //int i1 = 345;
        //float f = i1;

        //Debug.Log(f);


        ////convert string to time
        //var str = "5/12/2020";
        //System.DateTime dt;

        //var isValidDate = System.DateTime.TryParse(str, out dt);
        //Debug.Log(str);
        // end Tuesday

        // Wednesday

        //Creating a StringBuilder Object

        StringBuilder sb = new StringBuilder("Hello World!");

        for (int i = 0; i < sb.Length; i++)
           Debug.Log(sb[i]); // output: Hello World!

        //Retrieve String from StringBuilder

        StringBuilder sb1 = new StringBuilder("Hello World!");

        var greet = sb1.ToString(); //returns "Hello World!"
        Debug.Log(greet); // output: Hello World!

        //Add/Append String to StringBuilder

        StringBuilder sb2 = new StringBuilder();
        sb2.Append("Append ");
            sb2.Append("String ");
            sb2.AppendLine("to StringBuilder"); //create new line after this 
        sb2.AppendLine("This is new line of sb");
        Debug.Log(sb2);
        // Anonymous 
        var student = new { 
                            Id = 1, 
                            FirstName = "James",
                            LastName = "Bond",
                            Address = new { Id = 1, City = "London", Country = "UK" } 
                          };
        Debug.Log(student.Id); //output: 1
        Debug.Log(student.FirstName); //output: James
        Debug.Log(student.LastName); //output: Bond
        Debug.Log(student.Address.City); // output: London

        // passing value

        int passint = 100;

        Debug.Log(passint);

      passint=  ChangeValue(passint);

        Debug.Log(passint);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //function passing value
    public int ChangeValue(int x)
    {
        x = 200;

        return x;
    }

}

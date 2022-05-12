using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using ExtensionClass;
using System.Linq;

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

        //  StringBuilder sb = new StringBuilder("Hello World!");

        //  for (int i = 0; i < sb.Length; i++)
        //     Debug.Log(sb[i]); // output: Hello World!

        //  //Retrieve String from StringBuilder

        //  StringBuilder sb1 = new StringBuilder("Hello World!");

        //  var greet = sb1.ToString(); //returns "Hello World!"
        //  Debug.Log(greet); // output: Hello World!

        //  //Add/Append String to StringBuilder

        //  StringBuilder sb2 = new StringBuilder();
        //  sb2.Append("Append ");
        //      sb2.Append("String ");
        //      sb2.AppendLine("to StringBuilder"); //create new line after this 
        //  sb2.AppendLine("This is new line of sb");
        //  Debug.Log(sb2);
        //  // Anonymous 
        //  var student = new { 
        //                      Id = 1, 
        //                      FirstName = "James",
        //                      LastName = "Bond",
        //                      Address = new { Id = 1, City = "London", Country = "UK" } 
        //                    };
        //  Debug.Log(student.Id); //output: 1
        //  Debug.Log(student.FirstName); //output: James
        //  Debug.Log(student.LastName); //output: Bond
        //  Debug.Log(student.Address.City); // output: London

        //  // passing value

        //  int passint = 100;

        //  Debug.Log(passint);

        //passint=  ChangeValue(passint);

        //  Debug.Log(passint);
        //  //class
        //  Student student1 = new Student(1, "Alex");
        //  ChangeReferenceType(student1);
        //  string name_Student = student1.Name;
        //  Debug.Log(name_Student);

        //  //Operator
        //  string greet1 = "Hello " + "World!";
        //  string greet2 = greet1 + "C#";
        //  Debug.Log(greet2);

        //  int number1 = 10;
        //  int number2 = 20;
        //  int result = number1 + number2 - 10;
        //  Debug.Log(result);

        //  //Nullable
        //  int? inull = null;
        //  int jnull = 10;


        //  if (inull < jnull)
        //     Debug.Log("i < j");
        //  else if (inull > 10)
        //      Debug.Log("i > j");
        //  else if (inull == 10)
        //      Debug.Log("i == j");
        //  else
        //      Debug.Log("Could not compare");
        //  inull = 20;
        //  if (inull < jnull)
        //      Debug.Log("i < j");
        //  else if (inull > 10)
        //      Debug.Log("i > j");
        //  else if (inull == 10)
        //      Debug.Log("i == j");
        //  else
        //      Debug.Log("Could not compare");
        //  //Extension method
        //  int iextension = 10;

        //  bool resultextension = iextension.IsGreaterThan(100);

        //  Debug.Log(resultextension);

        //  //Static Class

        //  var resultcal = Calculator.Sum(10, 25); // calling static method
        //  Calculator.Store(resultcal);
        //  Debug.Log(resultcal);
        //  var calcType = Calculator.Type; // accessing static variable
        //  Calculator.Type = "Scientific"; // assign value to static variable
        //  Debug.Log(calcType);
        //  var calcType1 = Calculator.Type;
        //  Debug.Log(calcType1);

        // Thusday

        //if ifelse else statement
        int i = 10, j = 10;

        if (isGreater(i, j))
        {
            Debug.Log("i is less than j");
        }

       else if (isGreater(j, i))
        {
            Debug.Log("j is greater than i");
        }
        else
        {
            Debug.Log("i and j is equal");
        }

        //  Tenary Operator
        int x1 = 20, y1 = 10;

        var resultTenary = x1 > y1 ? "x1 is greater than y1" : "x1 is less than y1";

        Debug.Log(resultTenary);

        int x = 10, y = 100;

        string resultTenary1 = x > y ? "x is greater than y" :
                            x < y ? "x is less than y" :
                                x == y ? "x is equal to y" : "No result";

        Debug.Log(resultTenary1);


        //Switch

        int sw = 4;

        switch (sw)
        {
            case 1:
                Debug.Log("sw = 1");
                break;
            case 2:
                Debug.Log("sw = 2");
                break;
            case 4:
            case 5:
                Debug.Log("sw = 4 or sw = 5");
                break;
            default:
                Debug.Log("x > 5");
                break;
        }


        int swj = 5;

        switch (swj)
        {
            case 5:
                Debug.Log(5);
                switch (swj - 1)
                {
                    case 4:
                        Debug.Log(4);
                        switch (swj - 2)
                        {
                            case 3:
                                Debug.Log(3);
                                break;
                        }
                        break;
                }
                break;
            case 10:
                Debug.Log(10);
                break;
            case 15:
                Debug.Log(15);
                break;
            default:
                Debug.Log(100);
                break;
        }



        //For loop
        for (int iloop = 0; iloop < 10; iloop++)
        {
            if (iloop == 5)
                break;
            Debug.Log("iloop");
            Debug.Log(iloop);
        }

        for (int iNestLoop = 0; iNestLoop < 2; iNestLoop++)
        {
            for (int jNestLoop = iNestLoop; jNestLoop < 4; jNestLoop++)
            {
                Debug.Log("iNestLoop"); Debug.Log(iNestLoop);
                Debug.Log("jNestLoop"); Debug.Log(jNestLoop);
            }
                
        }

        // while
        Debug.Log(" while practice");
        int iWhile = 0, jWhile = 1;

        while (iWhile < 2)
        {
            Debug.Log("iWhile");
            Debug.Log(iWhile);
            iWhile++;

            while (jWhile < 2)
            {
                Debug.Log("jWhile");
                Debug.Log(jWhile);
                jWhile++;
            }
        }

        //do white

        int iDoWhile = 0;
        Debug.Log(" do while practice");
        do
        {
            Debug.Log("iDoWhile");
            Debug.Log(iDoWhile);
            iDoWhile++;

            if (iDoWhile > 5)
                break;

        } while (iDoWhile < 10);


        //Array
        string[] cities = { "Mumbai", "London", "New York" };

       
        foreach (var city in cities)
            Debug.Log(city);

        int[] nums = new int[5] { 10, 15, 16, 8, 6 };

        Debug.Log(nums.Max());
        Debug.Log(nums.Min());
        Debug.Log(nums.Sum());
        Debug.Log(nums.Average());

        //2d array

        int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };


        Debug.Log(arr2d[0, 0]); //returns 1
        Debug.Log(arr2d[0, 1]); //returns 2
        Debug.Log(arr2d[1, 0]);  //returns 3
        Debug.Log(arr2d[1, 1]); //returns 4
        Debug.Log(arr2d[2, 0]); //returns 5
        Debug.Log(arr2d[2, 1]); //returns 6

        //Jagged Array

        int[][][] intJaggedArray = new int[2][][]
                            {
                                new int[2][]
                                {
                                    new int[3] { 1, 2, 3},
                                    new int[2] { 4, 5}
                                },
                                new int[1][]
                                {
                                    new int[3] { 7, 8, 9}
                                }
                            };

       Debug.Log(intJaggedArray[0][0][0]); // 1

       Debug.Log(intJaggedArray[0][1][1]); // 5

       Debug.Log(intJaggedArray[1][0][2]); // 9

        //Array List
        var arlist1 = new ArrayList();

        var arlist2 = new ArrayList()
                    {
                        1, "Bill", " ", true, 4.5, null
                    };

        int[] arr = { 100, 200, 300, 400 };

        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World!");

        arlist1.AddRange(arlist2); //adding arraylist in arraylist 
        arlist1.AddRange(arr); //adding array in arraylist 
        arlist1.AddRange(myQ); //adding Queue in arraylist 
        //add item in index 1 in array
        arlist2.Insert(1, "Second Item");
        foreach (var val in arlist2)
           Debug.Log(val);
        //remove index 2 in array
        arlist2.RemoveAt(2);
        foreach (var val in arlist2)
            Debug.Log(val);

        //list 

        var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };
        string[] cities1 = new string[3] { "Mumbai", "London", "New York" };
        //add range
        bigCities.AddRange(cities1);
        foreach (var val in bigCities)
            Debug.Log(val);


        //sorted list
        SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

       Debug.Log(numberNames[1]); //output: One
       Debug.Log(numberNames[2]); //output: Two
       Debug.Log(numberNames[3]); //output: Three
                                  //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

        numberNames.RemoveAt(0);//removes key-value pair from index 0 
        numberNames.Remove(1);//removes key 1 pair
    }














    static bool isGreater(int i, int j)
    {
        return i > j;
    }

    public static void ChangeReferenceType(Student std2)
    {
        std2.Name = "Steve";
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

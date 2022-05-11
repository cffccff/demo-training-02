using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : ScriptableObject
{

    private int _id;
    private string _name;
    public Student()
    {

    }
    public Student(int _id, string _name)
    {

    }
    public int ID
    {
        get
        {
            return _id;
        }

        set
        {

            _id = value;
        }
    }
         public string Name
    {
        get
        {
            return _name;
        }

        set
        {

            _name = value;
        }
    }
   
  
}

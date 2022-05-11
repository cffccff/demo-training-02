using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator
{
    private static int _resultStorage = 0;

    public static string Type = "Arithmetic";

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Store(int result)
    {
        _resultStorage = result;
    }
}

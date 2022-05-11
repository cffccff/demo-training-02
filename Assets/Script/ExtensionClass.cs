using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExtensionClass 
{

    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public static class RandomGenerator
{
    public static System.Random rnd = new System.Random();
    
    public static float GetRandomNumber(double minimum, double maximum)
    {
        return (float)(rnd.NextDouble() * (maximum - minimum) + minimum);
    }
}

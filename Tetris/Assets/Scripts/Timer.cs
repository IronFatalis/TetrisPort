using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int StartTime = 10;
    public static int Speed = 10;

    public static float DropTime = Speed / 4;

    public static int PieceDrop = 0;

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Ticks()
    {
        DropTime -= Time.deltaTime;
    }

    public static void Reset()
    {
        DropTime = Speed / 4;
    }
}

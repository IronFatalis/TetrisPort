using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int StartTime = 10;
    public static int Speed = 10;

    public static float DropTime = Speed / 4;

    public static int PieceDrop = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DropTime -= Time.deltaTime;
    }

    public static void Reset()
    {
            DropTime = Speed / 4;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int StartTime = 10;
    public static int Speed = 10;

    private float DropTime = Speed / 4;

    public int PieceDrop = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DropTime -= Time.deltaTime;
        print(DropTime);
        if (PieceDrop >= DropTime)    //speed
        {
            Reset();
            PieceDrop = 0;
        }
    }

    void Reset()
    {
            DropTime = Speed / 4;
    }
}

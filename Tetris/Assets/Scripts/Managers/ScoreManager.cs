using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    private GameObject currentScore;

    public static string StrCurrentScore = "0";
    public int NumCurrentScore = Int32.Parse(StrCurrentScore);

    public static string StrLevel = "01";
    public int NumLevel = Int32.Parse(StrLevel);

    public static string StrHiScore = "100000";
    public int NumHiScore = Int32.Parse(StrHiScore);

    public static string StrLine = "00";
    public static int NumLine = Int32.Parse(StrLine);

    public static string StrTStat = "0";
    public static int NumTStat = Int32.Parse(StrTStat);

    public static string StrJStat = "0";
    public static int NumJStat = Int32.Parse(StrJStat);

    public static string StrZStat = "0";
    public static int NumZStat = Int32.Parse(StrZStat);

    public static string StrOStat = "0";
    public static int NumOStat = Int32.Parse(StrOStat);

    public static string StrSStat = "0";
    public static int NumSStat = Int32.Parse(StrSStat);

    public static string StrLStat = "0";
    public static int NumLStat = Int32.Parse(StrLStat);

    public static string StrIStat = "0";
    public static int NumIStat = Int32.Parse(StrIStat);


    // Start is called before the first frame update
    void Start()
    {
        currentScore = GameObject.Find("PlayerScore");
        //NumCurrentScore.GetComponent<UnityEngine.UI.Text>().text = NumCurrentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            NumCurrentScore = Int32.Parse(StrCurrentScore);
            NumCurrentScore += 1000;
            StrCurrentScore = NumCurrentScore.ToString().PadLeft(7,'0');
            print(StrCurrentScore);
            currentScore.GetComponent<UnityEngine.UI.Text>().text = StrCurrentScore;
        }
    }
}

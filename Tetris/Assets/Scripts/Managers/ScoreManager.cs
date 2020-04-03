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

    private static string StrLevel = "01";
    private int NumLevel = Int32.Parse(StrLevel);

    private static string StrHiScore = "100000";
    private int NumHiScore = Int32.Parse(StrHiScore);

    private static string StrLine = "00";
    private int NumLine = Int32.Parse(StrLine);

    private static string StrTStat = "0";
    static public int NumTStat = Int32.Parse(StrTStat);

    private static string StrJStat = "0";
    private int NumJStat = Int32.Parse(StrJStat);

    private static string StrZStat = "0";
    private int NumZStat = Int32.Parse(StrZStat);

    private static string StrOStat = "0";
    private int NumOStat = Int32.Parse(StrOStat);

    private static string StrSStat = "0";
    private int NumSStat = Int32.Parse(StrSStat);

    private static string StrLStat = "0";
    private int NumLStat = Int32.Parse(StrLStat);

    private static string StrIStat = "0";
    private int NumIStat = Int32.Parse(StrIStat);


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

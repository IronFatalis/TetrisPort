﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectType : MonoBehaviour
{
    private GameObject typeCursorLeft;
    private GameObject typeCursorRight;
    private GameObject musicCursorLeft;
    private GameObject musicCursorRight;

    private Vector2 NewMusicLocationLeft = new Vector2(284, 196);
    private Vector2 NewMusicLocationRight = new Vector2(395, 196);

    private double BottomMusic = 122.5;
    private double TopMusic = 196;

    //private Vector2 NewMusicLocationLeft = new Vector2(153, 130.5f);
    //private Vector2 NewMusicLocationRight = new Vector2(261, 130.5f);

    //private double BottomMusic = 57;
    //private double TopMusic = 130.5f;
    private float MusicDiffernce = 24.5f;

    public static int SelectMusic = 0;
    public int SelectMode = 0;
    public static int GameMode = -1;

    // Start is called before the first frame update
    void Start()
    {
        typeCursorLeft = GameObject.Find("TypeCursorLeft");
        typeCursorRight = GameObject.Find("TypeCursorRight");
        musicCursorLeft = GameObject.Find("MusicCursorLeft");
        musicCursorRight = GameObject.Find("MusicCursorRight");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            typeCursorLeft.transform.position = new Vector2(230,320);
            typeCursorRight.transform.position = new Vector2(316, 320);

            //typeCursorLeft.transform.position = new Vector2(94,253);
            //typeCursorRight.transform.position = new Vector2(180, 253);
            SelectMode = 0;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            typeCursorLeft.transform.position = new Vector2(370, 320);
            typeCursorRight.transform.position = new Vector2(456, 320);

            //typeCursorLeft.transform.position = new Vector2(234, 252);
            //typeCursorRight.transform.position = new Vector2(320, 252);
            SelectMode = 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && NewMusicLocationLeft.y > BottomMusic)
        {
            NewMusicLocationLeft.y = NewMusicLocationLeft.y - MusicDiffernce;
            NewMusicLocationRight.y = NewMusicLocationRight.y - MusicDiffernce;
            musicCursorLeft.transform.position = NewMusicLocationLeft;
            musicCursorRight.transform.position = NewMusicLocationRight;
            SelectMusic++;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && NewMusicLocationLeft.y < TopMusic)
        {
            NewMusicLocationLeft.y = NewMusicLocationLeft.y + MusicDiffernce;
            NewMusicLocationRight.y = NewMusicLocationRight.y + MusicDiffernce;
            musicCursorLeft.transform.position = NewMusicLocationLeft;
            musicCursorRight.transform.position = NewMusicLocationRight;
            SelectMusic--;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameMode = SelectMode;
            SceneManager.LoadScene(sceneName: "GameScreen");
        }
    }
}


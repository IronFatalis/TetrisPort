using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectType : MonoBehaviour
{
    private GameObject typeCursorLeft;
    private GameObject typeCursorRight;
    private int StartingLocation;
    private int TypeBDistance = 100;


    // Start is called before the first frame update
    void Start()
    {
        typeCursorLeft = GameObject.Find("TypeCursorLeft");
        typeCursorRight = GameObject.Find("TypeCursorRight");
        StartingLocation = -91;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x < StartingLocation)    // & cursor not already left
        {
            typeCursorLeft.transform.position.x = StartingLocation + TypeBDistance;    //Move cursor left
            typeCursorRight.transform.position.x = StartingLocation + TypeBDistance;    //Move cursor left
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x > StartingLocation)   // & cursor not already right
        {
            typeCursorLeft.transform.position.x = StartingLocation;    //Move cursor right
            typeCursorRight.transform.position.x = StartingLocation;    //Move cursor right
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneName: "GameScreen");
        }
    }
}


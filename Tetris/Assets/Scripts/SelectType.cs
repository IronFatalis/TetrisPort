using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))    // & cursor not already left
        {
            SceneManager.LoadScene(sceneName: "GameScreen");    //Move cursor left
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))   // & cursor not already right
        {
            SceneManager.LoadScene(sceneName: "GameScreen");    //Move cursor right
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneName: "GameScreen");
        }
    }
}


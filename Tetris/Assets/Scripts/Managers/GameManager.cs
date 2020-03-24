using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool ModeSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (ModeSelected == false)
        {
            if (SelectType.GameMode == 0)
            {
                ModeSelected = true;
            }
            else if (SelectType.GameMode == 1)
            {
                ModeSelected = true;
            }
        }
    }
}

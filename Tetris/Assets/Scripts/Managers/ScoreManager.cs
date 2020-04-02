using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text PlayerScore;
    public int NumPlayerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScore.GetComponent<UnityEngine.UI.Text>().text = NumPlayerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    private GameObject currentPiece;
    
    private Vector2 Tetromino = new Vector2(180f, 170f);


    // Start is called before the first frame update
    void Start()
    {
        currentPiece = GameObject.Find("CurrentPiece");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Tetromino.x = Tetromino.x - Grid.CellSize;
            currentPiece.transform.position = Tetromino;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Tetromino.x = Tetromino.x + Grid.CellSize;
            currentPiece.transform.position = Tetromino;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Tetromino.y = Tetromino.y - Grid.CellSize;
            currentPiece.transform.position = Tetromino;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Tetromino.y = Tetromino.y + Grid.CellSize;
            currentPiece.transform.position = Tetromino;
        }
    }
}

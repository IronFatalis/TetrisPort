using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    private GameObject currentPiece;
    
    private Vector2[] Tetromino = { new Vector2(180f, 170f), new Vector2(180f, 170f), new Vector2(180f, 170f), new Vector2(180f, 170f) };


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
            for (int i = 0; i < 4; i++)
            {
                if (Tetromino[i].x > 130)
                {
                    Tetromino[i].x = Tetromino[i].x - Grid.CellSize;
                    currentPiece.transform.position = Tetromino[i];
                    if (i == 3)
                    {
                        Grid.PieceRow--;
                    }
                    print(Grid.NewPos[i]);
                    print(Grid.PieceRow);
                }
            }
            // 180 = 180 - 10;
            // L130 - R230

            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            for (int i = 0; i < 4; i++)
            {
                if (Tetromino[i].x < 220)
                {
                    Tetromino[i].x = Tetromino[i].x + Grid.CellSize;
                    currentPiece.transform.position = Tetromino[i];
                    if (i == 3)
                    {
                        Grid.PieceRow++;
                    }
                    print(Grid.NewPos[i]);
                    print(Grid.PieceRow);
                }
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow) || (Timer.PieceDrop >= Timer.DropTime))
        {
            for (int i = 0; i < 4; i++)
            {
                if (Tetromino[i].y > -50)
                {
                    Tetromino[i].y = Tetromino[i].y - Grid.CellSize;
                    currentPiece.transform.position = Tetromino[i];
                }
            }
            Timer.Reset();
        }
    }
}

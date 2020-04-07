using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    private GameObject currentPiece;
    
    private Vector2[] StartLocation = { new Vector2(180f, 170f), new Vector2(180f, 170f), new Vector2(180f, 170f), new Vector2(180f, 170f) };
    private Vector2[] Tetromino;


    // Start is called before the first frame update
    void Start()
    {
        currentPiece = GameObject.Find("CurrentPiece");
        Tetromino = StartLocation;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int p = 0; p < 4; p++)
            {
                Grid.NewPos[p].x = (-1 * Grid.OldPos[p].y);
                Grid.NewPos[p].y = (1 * Grid.OldPos[p].x);
                Grid.CheckLR[p] = (Grid.PieceRow + Grid.NewPos[p].x);
                Grid.CheckUD[p] = (Grid.PieceColumn + Grid.NewPos[p].y);
            }
            if ((Grid.PieceRow + Grid.NewPos[0].x) < 9 && (Grid.PieceRow + Grid.NewPos[0].x) > 0 && (Grid.PieceRow + Grid.NewPos[1].x) < 9 && (Grid.PieceRow + Grid.NewPos[1].x) > 0 && (Grid.PieceRow + Grid.NewPos[2].x) < 9 && (Grid.PieceRow + Grid.NewPos[2].x) > 0 && (Grid.PieceRow + Grid.NewPos[3].x) < 9 && (Grid.PieceRow + Grid.NewPos[3].x) > 0 && Grid.PieceColumn < 23 && !Grid.LockedPiece[Grid.CheckUD[0]][Grid.CheckLR[0]] && !Grid.LockedPiece[Grid.CheckUD[1]][Grid.CheckLR[1]] && !Grid.LockedPiece[Grid.CheckUD[2]][Grid.CheckLR[2]] && !Grid.LockedPiece[Grid.CheckUD[3]][Grid.CheckLR[3]])
            {
                for (int p = 0; p < 4; p++)
                {
                    Grid.OldPos[p] = Grid.NewPos[p];
                }
            }
            else
            {
                for (int p = 0; p < 4; p++)
                {
                    Grid.NewPos[p].x = Grid.OldPos[p].x;
                    Grid.NewPos[p].y = Grid.OldPos[p].y;
                }
            }
            //Grid.CheckPosition();
        }
    }
}

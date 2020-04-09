using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    private GameObject currentPiece;
    private GameObject sidePiece1;
    private GameObject sidePiece2;
    private GameObject sidePiece3;

    private GameObject nextPiece;

    // Start is called before the first frame update
    void Start()
    {
        currentPiece = GameObject.Find("CurrentPiece1");
        sidePiece1 = GameObject.Find("CurrentPiece2");
        sidePiece2 = GameObject.Find("CurrentPiece3");
        sidePiece3 = GameObject.Find("CurrentPiece4");

        nextPiece = GameObject.Find("GameBackground");

    }

    // Update is called once per frame
    void Update()
    {
        currentPiece.transform.position = new Vector2((Grid.PieceRow * Grid.CellSize) + Grid.StartLocation.x, (Grid.PieceColumn * Grid.CellSize) + Grid.StartLocation.y);
        sidePiece1.transform.position = new Vector2(((Grid.PieceRow + Grid.OldPos[1].x) * Grid.CellSize) + Grid.StartLocation.x, ((Grid.PieceColumn - Grid.OldPos[1].y) * Grid.CellSize) + Grid.StartLocation.y);
        sidePiece2.transform.position = new Vector2(((Grid.PieceRow + Grid.OldPos[2].x) * Grid.CellSize) + Grid.StartLocation.x, ((Grid.PieceColumn - Grid.OldPos[2].y) * Grid.CellSize) + Grid.StartLocation.y);
        sidePiece3.transform.position = new Vector2(((Grid.PieceRow + Grid.OldPos[3].x) * Grid.CellSize) + Grid.StartLocation.x, ((Grid.PieceColumn - Grid.OldPos[3].y) * Grid.CellSize) + Grid.StartLocation.y);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Grid.PieceRow > 0 && (Grid.PieceRow + Grid.OldPos[1].x) > 0 && (Grid.PieceRow + Grid.OldPos[2].x) > 0 && (Grid.PieceRow + Grid.OldPos[3].x) > 0)
        {
            Grid.PieceRow--;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) && Grid.PieceRow < 10 && (Grid.PieceRow + Grid.OldPos[1].x) < 10 && (Grid.PieceRow + Grid.OldPos[2].x) < 10 && (Grid.PieceRow + Grid.OldPos[3].x) < 10)
        {
            Grid.PieceRow++;
        }


        if (Input.GetKey(KeyCode.DownArrow) && Grid.PieceColumn > -22 && (Grid.PieceColumn - Grid.OldPos[1].y) > -22  && (Grid.PieceColumn - Grid.OldPos[2].y) > -22 && (Grid.PieceColumn - Grid.OldPos[3].y) > -22 || (Timer.PieceDrop >= Timer.DropTime) && Grid.PieceColumn > -22)
        {
            Grid.PieceColumn--;
            Timer.Reset();
        }

        else if (Grid.PieceColumn <= -21 || (Grid.PieceColumn + Grid.OldPos[1].y) <= -21 || (Grid.PieceColumn + Grid.OldPos[2].y) <= -21 || (Grid.PieceColumn + Grid.OldPos[3].y) <= -21 )
        {
            nextPiece.GetComponent<Grid>().LockedGrid();
            Grid.PieceRow = 5;
            Grid.PieceColumn = 1;

            nextPiece.GetComponent<RandomGenerator>().SetCurrentPiece();
            nextPiece.GetComponent<RandomGenerator>().SetNextPiece();

            currentPiece.transform.position = new Vector2((Grid.PieceRow * Grid.CellSize) + Grid.StartLocation.x, (Grid.PieceColumn * Grid.CellSize) + Grid.StartLocation.y);
            sidePiece1.transform.position = new Vector2(((Grid.PieceRow + Grid.OldPos[1].x) * Grid.CellSize) + Grid.StartLocation.x, ((Grid.PieceColumn + Grid.OldPos[1].y) * Grid.CellSize) + Grid.StartLocation.y);
            sidePiece2.transform.position = new Vector2(((Grid.PieceRow + Grid.OldPos[2].x) * Grid.CellSize) + Grid.StartLocation.x, ((Grid.PieceColumn + Grid.OldPos[2].y) * Grid.CellSize) + Grid.StartLocation.y);
            sidePiece3.transform.position = new Vector2(((Grid.PieceRow + Grid.OldPos[3].x) * Grid.CellSize) + Grid.StartLocation.x, ((Grid.PieceColumn + Grid.OldPos[3].y) * Grid.CellSize) + Grid.StartLocation.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int p = 0; p < 4; p++)
            {
                Grid.NewPos[p].x = (-1 * Grid.OldPos[p].y);
                Grid.NewPos[p].y = (1 * Grid.OldPos[p].x);
            }
            if ((Grid.PieceRow + Grid.NewPos[0].x) > 0 && (Grid.PieceRow + Grid.NewPos[1].x) > 0 && (Grid.PieceRow + Grid.NewPos[2].x) > 0 && (Grid.PieceRow + Grid.NewPos[3].x) > 0 && (Grid.PieceRow + Grid.NewPos[0].x) < 10 && (Grid.PieceRow + Grid.NewPos[1].x) < 10 && (Grid.PieceRow + Grid.NewPos[2].x) < 10 && (Grid.PieceRow + Grid.NewPos[3].x) < 10)
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
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            nextPiece.GetComponent<Grid>().LockedGrid();
        }
    }
    
}

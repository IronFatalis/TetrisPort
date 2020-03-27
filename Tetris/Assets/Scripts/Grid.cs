using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
	private int GridRows = 10;
	private int GridColumns = 24;
	static public int PieceColumn = 1;
	static public int PieceRow = 5;
	static public float CellSize = 10f;
	static int MaxBlocks = 4;

	static public Vector2[] NewPos = new Vector2[MaxBlocks];
	static public Vector2[] OldPos = new Vector2[MaxBlocks];

	// Start is called before the first frame update
	void Start()
    {
		for (int i = 0; i < GridColumns; i++)
		{
			for (int j = 0; j < GridRows; j++)
			{
				if (PieceRow == j && PieceColumn == i)
				{
					OldPos[0] = new Vector2(180, 170);
					OldPos[1] = new Vector2(170, 170);
					OldPos[2] = new Vector2(190, 170);
					OldPos[3] = new Vector2(180, 160);
					//pieceshape()
					MovementCalc();
				}
			}
		}
	}

    // Update is called once per frame
    void Update()
    {
		for (int i = 0; i < GridColumns; i++)
		{
			for (int j = 0; j < GridRows; j++)
			{
				if (PieceRow == j && PieceColumn == i)
				{
					OldPos[0] = new Vector2(180, 170);
					OldPos[1] = new Vector2(170, 170);
					OldPos[2] = new Vector2(190, 170);
					OldPos[3] = new Vector2(180, 160);
					//pieceshape()
					MovementCalc();
				}
			}
		}
	}

	void MovementCalc()
	{
		for (int p = 0; p < 4; p++)
		{
			//newpos = (5*10) + (180)  ,   (1*10) + (170)
			//			60
			NewPos[p] = new Vector2((PieceRow * CellSize) + (OldPos[p].x), (PieceColumn *CellSize) + (OldPos[p].y));
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
	public int GridRows = 10;
	public int GridColumns = 24;
	public int PieceColumn = 1;
	public int PieceRow = 5;
	static public float CellSize = 10f;

	public Vector2[] NewPos = new Vector2[4];
	public Vector2[] OldPos = new Vector2[4];

	// Start is called before the first frame update
	void Start()
    {
		for (int i = 0; i < 24; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				if (PieceRow == j && PieceColumn == i)
				{
					//pieceshape()
					MovementCalc();
				}
			}
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void MovementCalc()
	{
		for (int p = 0; p < 4; p++)
		{
			Vector2[p] NewPos = new Vector2[p]((PieceRow * CellSize) + (CellSize * OldPos[p].x), (PieceColumn *CellSize) + (CellSize * OldPos[p].y));
		}
	}
}

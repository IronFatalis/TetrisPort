using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
	GameObject lockGrid;
	SpriteRenderer Render;
	Texture2D BlockTex;
	Sprite LockedBlock;
	public GameObject curCanvas;
	public GameObject piecePrefab;

	private int GridRows = 10;
	private int GridColumns = 24;
	static public int PieceColumn = 1;
	static public int PieceRow = 5;
	static public int CellSize = 10;
	static int MaxBlocks = 4;

	static public Vector2Int StartLocation = new Vector2Int(150, 260);
	static public Vector2Int[] NewPos = new Vector2Int[MaxBlocks];
	static public Vector2Int[] OldPos = new Vector2Int[MaxBlocks];

	// Start is called before the first frame update
	void Start()
    {
		for (int i = 0; i < GridColumns; i++)
		{
			for (int j = 0; j < GridRows; j++)
			{
				if (PieceRow == j && PieceColumn == i)
				{
					//OldPos[0] = new Vector2Int(180, 170);
					//OldPos[1] = new Vector2Int(170, 170);
					//OldPos[2] = new Vector2Int(190, 170);
					//OldPos[3] = new Vector2Int(180, 160);
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
					//OldPos[0] = new Vector2Int(180, 170);
					//OldPos[1] = new Vector2Int(170, 170);
					//OldPos[2] = new Vector2Int(190, 170);
					//OldPos[3] = new Vector2Int(180, 160);
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
			NewPos[p] = new Vector2Int((PieceRow * CellSize) + (OldPos[p].x), (PieceColumn *CellSize) + (OldPos[p].y));
		}
	}


	public void LockedGrid()
	{
		Vector3 pos = new Vector3(((PieceRow + OldPos[0].x) * CellSize) + StartLocation.x, ((PieceColumn - OldPos[0].y) * CellSize) + StartLocation.y,0);
		GameObject newOBJ = Instantiate<GameObject>(piecePrefab, pos, Quaternion.identity);
		newOBJ.transform.parent = curCanvas.transform;

		pos = new Vector3(((PieceRow + OldPos[1].x) * CellSize) + StartLocation.x, ((PieceColumn - OldPos[1].y) * CellSize) + StartLocation.y, 0);
		newOBJ = Instantiate<GameObject>(piecePrefab, pos, Quaternion.identity);
		newOBJ.transform.parent = curCanvas.transform;

		pos = new Vector3(((PieceRow + OldPos[2].x) * CellSize) + StartLocation.x, ((PieceColumn - OldPos[2].y) * CellSize) + StartLocation.y, 0);
		newOBJ = Instantiate<GameObject>(piecePrefab, pos, Quaternion.identity);
		newOBJ.transform.parent = curCanvas.transform;

		pos = new Vector3(((PieceRow + OldPos[3].x) * CellSize) + StartLocation.x, ((PieceColumn - OldPos[3].y) * CellSize) + StartLocation.y, 0);
		newOBJ = Instantiate<GameObject>(piecePrefab, pos, Quaternion.identity);
		newOBJ.transform.parent = curCanvas.transform;
	}
}

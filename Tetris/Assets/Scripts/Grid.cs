using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
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

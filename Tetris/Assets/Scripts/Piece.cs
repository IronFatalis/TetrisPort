using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{



	// Start is called before the first frame update
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
        
    }


	void PieceShape()
	{
		Grid.OldPos[0] = new Vector2Int(0, 0);
		switch (RandomGenerator.GetCurrentPiece())
		{                                                                                           //+right												+down
			case 0: //T		//center
				Grid.OldPos[1] = new Vector2Int(1, 0);
				Grid.OldPos[2] = new Vector2Int(-1, 0);
				Grid.OldPos[3] = new Vector2Int(0, 1);
				break;

			case 1: //J		//center line
				Grid.OldPos[1] = new Vector2Int(0, -1);
				Grid.OldPos[2] = new Vector2Int(0, 1);
				Grid.OldPos[3] = new Vector2Int(-1, 1);
				break;

			case 2: //Z		//bottom right
				Grid.OldPos[1] = new Vector2Int(1, 0);
				Grid.OldPos[2] = new Vector2Int(0, -1);
				Grid.OldPos[3] = new Vector2Int(-1, -1);
				break;

			case 3: //O		//none
				Grid.OldPos[1] = new Vector2Int(1, 0);
				Grid.OldPos[2] = new Vector2Int(0, 1);
				Grid.OldPos[3] = new Vector2Int(1, 1);
				break;

			case 4: //S		//top left
				Grid.OldPos[1] = new Vector2Int(1, 0);
				Grid.OldPos[2] = new Vector2Int(0, 1);
				Grid.OldPos[3] = new Vector2Int(-1, 1);
				break;

			case 5: //L		//center line
				Grid.OldPos[1] = new Vector2Int(0, -1);
				Grid.OldPos[2] = new Vector2Int(0, 1);
				Grid.OldPos[3] = new Vector2Int(1, 1);
				break;

			case 6: //I		//second in
				Grid.OldPos[1] = new Vector2Int(0, -1);
				Grid.OldPos[2] = new Vector2Int(0, 1);
				Grid.OldPos[3] = new Vector2Int(0, 2);
				break;
		}
	}

	void NewPiece()
	{

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		for (int i = 0; i < 24; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				//if (pieceRow == j && pieceColumn == i)
				//{
					for (int z = 0; z < 4; z++)
					{
						//GridPiece[z][mColumns][mRows] = new Texture("GameSprites.png", 38, 160, 7, 7);
						//GridPiece[z][mColumns][mRows]->SetParent(this);
						//GridPiece[z][mColumns][mRows]->SetScale(Vector2(3.5f, 3.5f));
					}
					//Tetromino			PieceShape();
					//Movement			GridPiece[p][mColumns][mRows]->SetPosition(Graphics::SCREEN_WIDTH * 0.395f + ((pieceRow * slotSize) + (slotSize * oldPos[p].x)), Graphics::SCREEN_HEIGHT * 0.185f + (pieceColumn * slotSize) + (slotSize * oldPos[p].y));
				//}
			}
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

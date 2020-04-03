using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public static int mRandomPieceCurrent = 0;
    public static int mRandomPieceNext = 0;

	private GameObject playerScore;

	// Start is called before the first frame update
	void Start()
    {
        SetNextPiece();
        SetCurrentPiece();
        SetNextPiece();

		playerScore = GameObject.Find("PlayerScore");
	}

    // Update is called once per frame
    void Update()
    {
		// if piece locks
		//setCurrentPiece()
		//SetNextPiece();


		
	}

    int GetNextPiece()
    {
        return mRandomPieceNext;
    }

    void SetNextPiece()
    {
        mRandomPieceNext = (Random.Range(0, 7));
    }

    int GetCurrentPiece()
    {
        return mRandomPieceCurrent;
    }

    void SetCurrentPiece()
    {
        mRandomPieceCurrent = mRandomPieceNext;

		//switch (mRandomPieceCurrent)
		//{
		//	case 0:
		//		playerScore.NumTStat += 1;
		//		ScoreManager.StrTStat = ScoreManager.NumTStat.ToString();
		//		break;
		//	case 1:
		//		ScoreManager.NumJStat += 1;
		//		ScoreManager.StrJStat = ScoreManager.NumJStat.ToString();
		//		break;
		//	case 2:
		//		ScoreManager.NumZStat += 1;
		//		ScoreManager.StrZStat = ScoreManager.NumZStat.ToString();
		//		break;
		//	case 3:
		//		ScoreManager.NumOStat += 1;
		//		ScoreManager.StrOStat = ScoreManager.NumOStat.ToString();
		//		break;
		//	case 4:
		//		ScoreManager.NumSStat += 1;
		//		ScoreManager.StrSStat = ScoreManager.NumSStat.ToString();
		//		break;
		//	case 5:
		//		ScoreManager.NumLStat += 1;
		//		ScoreManager.StrLStat = ScoreManager.NumLStat.ToString();
		//		break;
		//	case 6:
		//		ScoreManager.NumIStat += 1;
		//		ScoreManager.StrIStat = ScoreManager.NumIStat.ToString();
		//		break;
		//}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public static int mRandomPieceCurrent = 0;
    public static int mRandomPieceNext = 0;

	private GameObject tStat;
	private GameObject jStat;
	private GameObject zStat;
	private GameObject oStat;
	private GameObject sStat;
	private GameObject lStat;
	private GameObject iStat;

	// Start is called before the first frame update
	void Start()
    {
		tStat = GameObject.Find("TStat");
		jStat = GameObject.Find("JStat");
		zStat = GameObject.Find("ZStat");
		oStat = GameObject.Find("OStat");
		sStat = GameObject.Find("SStat");
		lStat = GameObject.Find("LStat");
		iStat = GameObject.Find("IStat");

		SetNextPiece();
        SetCurrentPiece();
		print("set");
        SetNextPiece();
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

		switch (mRandomPieceCurrent)
		{
			case 0:
				ScoreManager.NumTStat += 1;
				ScoreManager.StrTStat = ScoreManager.NumTStat.ToString().PadLeft(2, '0');
				tStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrTStat;
				break;
			case 1:
				ScoreManager.NumJStat += 1;
				ScoreManager.StrJStat = ScoreManager.NumJStat.ToString().PadLeft(2, '0');
				jStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrJStat;
				break;
			case 2:
				ScoreManager.NumZStat += 1;
				ScoreManager.StrZStat = ScoreManager.NumZStat.ToString().PadLeft(2, '0');
				zStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrZStat;
				break;
			case 3:
				ScoreManager.NumOStat += 1;
				ScoreManager.StrOStat = ScoreManager.NumOStat.ToString().PadLeft(2, '0');
				oStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrOStat;
				break;
			case 4:
				ScoreManager.NumSStat += 1;
				ScoreManager.StrSStat = ScoreManager.NumSStat.ToString().PadLeft(2, '0');
				sStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrSStat;
				break;
			case 5:
				ScoreManager.NumLStat += 1;
				ScoreManager.StrLStat = ScoreManager.NumLStat.ToString().PadLeft(2, '0');
				lStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrLStat;
				break;
			case 6:
				ScoreManager.NumIStat += 1;
				ScoreManager.StrIStat = ScoreManager.NumIStat.ToString().PadLeft(2, '0');
				iStat.GetComponent<UnityEngine.UI.Text>().text = ScoreManager.StrIStat;
				break;
		}
	}
}

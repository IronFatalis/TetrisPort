using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public static int mRandomPieceCurrent = 0;
    public static int mRandomPieceNext = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetNextPiece();
        SetCurrentPiece();
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
    }
}

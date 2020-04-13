using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public static bool PieceLock = false;
    private GameObject resetPiece;

    void Start()
    {
        resetPiece = GameObject.Find("CurrentPiece1");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LockedPieces")
        {
            print("Hit");
            PieceLock = true;
            //resetPiece.GetComponent<PieceMovement>().NewPiece();
        }
    }
}

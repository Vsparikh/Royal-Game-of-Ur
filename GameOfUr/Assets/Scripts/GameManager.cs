using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Turn: ushort
{
    Player1Turn = 0,
    Player2Turn = 1, 
}

public enum GameState
{
    WaitingForPlayer1,
    WaitingForPlayer2,
    GameOver,
    Busy
}

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTileTouched(TileInfo info)
    {

    }

    public void OnPieceTouched(Piece piece)
    {

    }

    public void OnTileTouched(Tile tile)
    {

    }

}

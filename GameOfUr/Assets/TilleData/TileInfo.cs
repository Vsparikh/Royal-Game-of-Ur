using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Tile", menuName = "Tile")]
public class TileInfo : ScriptableObject
{
    public enum TileOwner { Empty, player1, player2 };
    public TileInfo[] nextTile;
    public TileOwner currentOwner;
    public bool IsSafeTile; 
}

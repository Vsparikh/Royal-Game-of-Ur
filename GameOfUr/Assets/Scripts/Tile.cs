using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : TouchObj
{
    [SerializeField]
    private TileInfo info;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void onTouched()
    {
    }

    public bool IsSafeTile() { return info.IsSafeTile;  }

    public TileInfo.TileOwner GetOwner() { return info.currentOwner; }

    public void SetOwner(TileInfo.TileOwner owner) { info.currentOwner = owner; }
}

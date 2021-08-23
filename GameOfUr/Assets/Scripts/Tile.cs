using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private TileInfo info;

    private Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTouched())
        {
            // tell manager that player clicked this piece
            Debug.Log("YAY Tile");
        }
    }

    public bool IsSafeTile() { return info.IsSafeTile;  }

    public TileInfo.TileOwner GetOwner() { return info.currentOwner; }

    public void SetOwner(TileInfo.TileOwner owner) { info.currentOwner = owner; }

    private bool IsTouched()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosRaw = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(touchPosRaw.x, touchPosRaw.y);

            return col == Physics2D.OverlapPoint(touchPos);

        }
        return false;
    }
}

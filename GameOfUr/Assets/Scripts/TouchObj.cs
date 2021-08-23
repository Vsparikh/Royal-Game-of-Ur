using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TouchObj : MonoBehaviour
{
    private Collider2D col;

    private bool listenToTouch = false;

    protected virtual void Start()
    {
        col = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        if(listenToTouch)
        {
            if (IsTouched())
            {
                onTouched();
            }
        }
    }
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

    protected virtual void onTouched() { }

    public void ListenToTouch(bool shouldListen) { listenToTouch = shouldListen; }
}

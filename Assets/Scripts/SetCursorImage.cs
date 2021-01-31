using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursorImage : MonoBehaviour
{
    public Texture2D cursorDownTexture;
    public Texture2D cursorUpTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private void Start()
    {
        Cursor.SetCursor(cursorUpTexture, hotSpot, cursorMode);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(cursorDownTexture, hotSpot, cursorMode);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(cursorUpTexture, hotSpot, cursorMode);
        }
    }

}

using UnityEngine;
public class CursorManager : MonoBehaviour
{
    public Texture2D cursorIdle;
    public Texture2D cursorClick;

    public Vector2 hotSpot = Vector2.zero;
    public CursorMode cursorMode = CursorMode.Auto;

    void Start()
    {
        Cursor.visible = false; //originalniot kursor da ne se gleda.
        // Set default cursor
        Cursor.SetCursor(cursorIdle, hotSpot, cursorMode);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // when mouse is clicked
        {
            Cursor.SetCursor(cursorClick, hotSpot, cursorMode);
        }
        else if (Input.GetMouseButtonUp(0)) // when mouse is released
        {
            Cursor.SetCursor(cursorIdle, hotSpot, cursorMode);
        }
    }
}
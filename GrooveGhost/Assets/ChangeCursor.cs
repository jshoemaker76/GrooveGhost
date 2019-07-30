using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D texture;
    void Start()
    {
        Vector2 cursorHotspot = new Vector2(texture.width / 2, texture.height / 2);
        Cursor.SetCursor(texture, cursorHotspot, CursorMode.Auto);
    }

    private void Update()
    {

    }
}

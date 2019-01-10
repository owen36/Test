using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowDrag : MonoBehaviour
{
    public Transform window;
    private float offsetX, offsetY;

    public void BeginDrag()
    {
        offsetX = window.position.x - Input.mousePosition.x;
        offsetY = window.position.y - Input.mousePosition.y;
    }

    public void OnDrag()
    {
        window.position = new Vector3(offsetX + Input.mousePosition.x, offsetY + Input.mousePosition.y);
    }
}

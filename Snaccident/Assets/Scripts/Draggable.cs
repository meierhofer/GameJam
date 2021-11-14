using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum sushi_type {
    Avocado, Salmon, Radish, White, Burger
}

public class Draggable : MonoBehaviour
{
    public sushi_type type;

    public delegate void DagEndedDelegate(Draggable draggableObject);

    public DagEndedDelegate dragEndedCallback;

    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;

    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
        dragEndedCallback(this);
    }
}

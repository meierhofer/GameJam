using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropController : MonoBehaviour
{

    public bool snapToGrid = true;
    public bool smartDrag = true;
    public bool isDraggable = true;
    public bool isDragged = false;
    Vector2 initialPositionMouse;
    Vector2 initialPositionObject;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (isDragged)
        {

        

            if(!smartDrag)
            {
                transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
                transform.position = initialPositionObject + (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - initialPositionMouse;
            }
            if (snapToGrid)
            {
                //transform.position.x = 1;
                transform.position = new Vector2(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y)) ;
            }
        }
    }

    private void OnMouseOver()
    {
        
    }
}

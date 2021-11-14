using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnapController : MonoBehaviour
{
    public List<SnapPoint> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Draggable draggable in draggableObjects)
        {
            draggable.dragEndedCallback = OnDragEnded;
        }
        Invoke("CheckSushi", 30f);
    }

   private void OnDragEnded(Draggable draggable)
    {
        float closestDistance = -1;
        SnapPoint closestSnapPoint = null;

        foreach(var snapPoint in snapPoints)
        {
            float currentDistance = Vector3.Distance(draggable.transform.position, snapPoint.transform.position);
            currentDistance = Mathf.Abs(currentDistance);
            if(closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }
        if(closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.position = closestSnapPoint.transform.position;
            closestSnapPoint.sushi = draggable;
        }
    }

    private void CheckSushi()
    {
        
        foreach(var Sushi in snapPoints)
        {
            
            if(Sushi.CorrectSushi() == false)
            {
                SceneManager.LoadScene("FailScene");
            }
            else if(Sushi.CorrectSushi() == true)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }

    
}

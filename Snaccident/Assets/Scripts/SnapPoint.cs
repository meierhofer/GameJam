using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapPoint : MonoBehaviour
{
    public Draggable sushi;
    public sushi_type type;
    public bool CorrectSushi() {
        if(!sushi)
        {
            return false;
        }
        return sushi.type == type;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

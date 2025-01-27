using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBogus : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0f, 1f)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButton(0) && mousePos.x < 350 && mousePos.x > 50 && mousePos.y < 400 )
        {
            //Debug.Log("Mouse was pressed on the LEFT side of the screen");
            // make bogus character get big and small rapidly
            t += 0.001f;
            if (t > 0.35f)
            {
                t = 0.3f;
            }
        }
        
        
        
        
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}

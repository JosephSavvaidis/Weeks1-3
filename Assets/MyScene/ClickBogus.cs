using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBogus : MonoBehaviour
{
    // this animation curve is used to public to create accessibility in the inspector
    // evaluate how the character's scale changes over time (based on t)
    public AnimationCurve curve;

    // t is the parameter im gonna evaluate with the AnimationCurve
    // range allows me to set this value between 0 and 1 in the inspector
    [Range(0f, 1f)]
    public float t;


    // Start is called before the first frame update
    void Start()
    {
        // Initialize t to 0.3. This will be my starting point on the curve. I set it to 0.3 because i dont want it to start at 0!!
        t = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current mouse position in screen coordinates/pixels
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButton(0) && mousePos.x < 350 && mousePos.x > 50 && mousePos.y < 400 )
        {
            //Debug.Log("Mouse was pressed on the LEFT side of the screen");
            // make bogus character get big and small rapidly
            t += 0.005f;
            if (t > 0.35f)
            {
                t = 0.3f;
            }
        }

        // Evaluate the curve at parameter t. The result is a float that controls scale
        // Multiply Vector2.one (which is (1, 1)) by this value to scale both X and Y 

        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}

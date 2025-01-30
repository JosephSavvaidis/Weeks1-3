using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpingHead : MonoBehaviour
{
    //THERE IS NO LERPING IN THIS SCRIPT, I WAS GONNA DO IT HERE BUT IM DOING IT IN ANOTHER SCRIPT!!!!!!!!!!!!!


    // This animation curve will be used to smoothly vary the object's scale
    public AnimationCurve curve;
    //ranges locks the value of t to 0 to 1
    [Range(0f, 1f)]
    public float t;

    // A variable that checks whether i want t to increase or decrease
    private bool getBigger;

    //variables to control offset and range determines how large or small the oscillations can be
    public float scaleOffset;
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        //setting t at 0.5 because i dont want it to start any lower
        t = 0.5f;
        getBigger = true;
    }

    // Update is called once per frame
    void Update()
    {


        // If getBigger is true, increase t over time
        if (getBigger == true)
        {
            t += 0.005f;
        }// Otherwise, decrease t over time
        else if (getBigger == false) {
            t -= 0.005f;
        }
        // If t exceeds 1, switch to shrinking mode
        if (t > 1f)
            {
            getBigger = false;
            }if (t < 0f) {
            getBigger = true;
            }
        // Use the curve to evaluate the scaling factor, then multiply by 'range'
        // and add the ofset This results in oscillating growth/shrinkage
        transform.localScale = Vector2.one * (curve.Evaluate(t) * range + scaleOffset);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpingHead : MonoBehaviour
{


    public AnimationCurve curve;
    [Range(0f, 1f)]
    public float t;

    // A variable that checks whether i want t to increase or decrease
    private bool getBigger;
    // Start is called before the first frame update
    void Start()
    {
        t = 0.5f;
        getBigger = true;
    }

    // Update is called once per frame
    void Update()
    {



        if (getBigger == true)
        {
            t += 0.001f;
        }
        else if (getBigger == false) {
            t -= 0.001f;
        }
            
            if (t > 1f)
            {
            getBigger = false;
            }if (t < 0.5f) {
            getBigger = true;
            }
        
        transform.localScale = Vector2.one * curve.Evaluate(t) * 0.3f;
    }
}

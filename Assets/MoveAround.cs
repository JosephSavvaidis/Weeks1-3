using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    float speed = 0.1f;
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public bool jump = false;
    public bool falling = false;
    bool goDown = false;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        Vector2 squarePosition = transform.position;
        squarePosition.x += speed;



        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(squarePosition);

        if (squarePosition.x < -10 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;

        }
        transform.position = squarePosition;
        
         if (jump == true) {
            transform.position += transform.up * curve.Evaluate(t) * Time.deltaTime;
            //curve.Evaluate(t);

            
                t += Time.deltaTime;
            
            
        }
        if (t > 1) {

            goDown = true;
            t = 0;
            //jump = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
     float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 squarePosition = transform.position;
        squarePosition.x += speed;

        

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(squarePosition);

        if (squarePosition.x < -10 || squareInScreenSpace.x > Screen.width) {
            speed = speed * -1;
        
        }
        transform.position = squarePosition;
    }
}

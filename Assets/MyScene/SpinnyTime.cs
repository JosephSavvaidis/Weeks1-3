using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyTime : MonoBehaviour
{
    private float rotationZ;
    //control spped of rotation
    public float rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        //increase rotation over time
        rotationZ += Time.deltaTime * rotationSpeed;

        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        //checking if my mouse is held down while over crazy face character
        if (Input.GetMouseButton(0) && mousePosition.x > 415 && mousePosition.x < 575 && mousePosition.y > 235 && mousePosition.y < 425)
        {
            rotationSpeed += 0.25f;
        }
        else {
            rotationSpeed -= 0.1f;
        }
        if (rotationSpeed < 50) {
            rotationSpeed = 50;
        }
    }
}

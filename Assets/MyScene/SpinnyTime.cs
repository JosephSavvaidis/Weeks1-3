using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class SpinnyTime : MonoBehaviour
{//finished
    //stores the current Z-axis rotation of the object
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
        //getting the mouse position with te screen coordinates(pixels).
        Vector3 mousePosition = Input.mousePosition;

        // Increase the rotation around the Z-axis over time, based on rotationSpeed
        // Time.deltaTime ensures the rotation is frame rate independent so that it moves the same no matter what frame rate
        rotationZ += Time.deltaTime * rotationSpeed;

        //apply the new Z-axis rotation to the transform using Euler angles
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        //checking if my mouse is held down while over crazy face character
        if (Input.GetMouseButton(0) && mousePosition.x > 415 && mousePosition.x < 575 && mousePosition.y > 235 && mousePosition.y < 425)
        {
            //increment rotationspped if im clicking crazy face character
            rotationSpeed += 0.6f;
        }
        else {
            //decrease rotation speed if im not clicking on crazy face character
            rotationSpeed -= 0.1f;
        }
        //this code makes sure that there is a minimum speed that crazy face will rotate
        if (rotationSpeed < 50) {
            rotationSpeed = 50;
        }
    }
}

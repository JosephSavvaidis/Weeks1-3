using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationClock : MonoBehaviour
{
    private float rotZ;
    public float rotationSpeed;
    public bool rotateRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateRight == true)
        {
            rotZ -= Time.deltaTime * rotationSpeed;
        }
        else if (rotateRight == false) {
            rotZ += Time.deltaTime * rotationSpeed;
        }
        

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightFollowMouse : MonoBehaviour
{
    // gameobject for flash
    public GameObject flash;

    
    

    // A variable to track whether the flashlight is on
    private bool lightOn;

    // Start is called before the first frame update
    void Start()
    {
        // Initially, the flashlight is off
        lightOn = false;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        // Convert mouse screen position to a position in the world
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Move this parent object to follow the mouse
        transform.position = mouseWorldPos;

        // Turn the flashlight on if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            lightOn = true;
        }
        // Turn it off if the left mouse button is released
        else if (Input.GetMouseButtonUp(0))
        {
            lightOn = false;
        }

        // If flashlight is on, place sprites at their original local positions.
        // If off, teleport them far off-screen.
        if (lightOn)
        {
            flash.transform.localPosition = mouseWorldPos;
            
        }
        else
        {
            //  move them to a very large coordinate
            Vector3 offScreenPos = new Vector3(9999f, 9999f, 0f);

            flash.transform.localPosition = offScreenPos;
            
        }
    }
}

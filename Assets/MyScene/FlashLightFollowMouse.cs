using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightFollowMouse : MonoBehaviour
{
    //getting the sprite renderer of the flash
    public SpriteRenderer rend1;
    public SpriteRenderer rend2;
    public SpriteRenderer rend3;
    //variable to check if light is on
    private bool lightOn;
    // Start is called before the first frame update
    void Start()
    {
        // Initially set the flashlight to off
        lightOn = false;
    }

    // Update is called once per frame
    void Update()
    {   
        //setting flashlight cast to mouse position
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouse;

        // Check if the left mouse button was pressed this frame
        // If pressed, turn the flashlight on.
        if (Input.GetMouseButtonDown(0))
        {
            lightOn = true;

        }
        // If the left mouse button is released, turn the flashlight off.
        else if (Input.GetMouseButtonUp(0)) {
            lightOn = false;
        }
        if (lightOn == true) {
            //enabling all flashlight renderers
            rend1.enabled = true;
            rend2.enabled = true;
            rend3.enabled = true;
        }else if ((lightOn == false))
        {
            //disabling all flashlight renderers
            rend1.enabled = false;
            rend2.enabled = false;
            rend3.enabled = false;  
        }
    }
}

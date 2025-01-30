using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpLeftToRight : MonoBehaviour
{
    
    // Boundaries on the X-axis
    public float leftBoundary = -13f;
    public float rightBoundary = 16f;

    // How many seconds it should take to go from left to right (or vice versa)
    public float moveDuration = 2f;

    // Overall speed multiplier
    public float speed = 1f;

    // Tracks elapsed time used in PingPong
    private float timeTracker;
    private void Start()
    {
        
    }
    void Update()
    {
        // Accumulate time, scaled by speed
        timeTracker += Time.deltaTime * speed;

        // pigPong oscillates between 0 and moevduration
        float pingPongValue = Mathf.PingPong(timeTracker, moveDuration);

        // Normalize that PingPong value to [0 to 1]
        float t = pingPongValue / moveDuration;

        // SmoothStep creates an "ease in/out" effect,
        // slowing near 0 and 1, speeding up in the middle
        float easedT = Mathf.SmoothStep(0f, 1f, t);

        // Lerp the objects X position between the two boundaries
        float xPos = Mathf.Lerp(leftBoundary, rightBoundary, easedT);

        // Update the game objects position
        transform.position = new Vector2(xPos, transform.position.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust this value to control the vertical speed of the drill bit
    private Vector2 initialPosition; // 2D Vector, x and y coordinates
    
    // Start is called before the first frame update
    void Start()
    {
    	// transform component represents the position, rotation and scale of a GameObject(DrillBit) in 2D or 3D space 
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //move the drill bit downward continuously
        float newY = initialPosition.y - speed * Time.time;
        transform.position = new Vector2(transform.position.x, newY);
    }
}

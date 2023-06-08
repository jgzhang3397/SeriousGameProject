using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the GameObject the camera to follow

    private Vector2 offset; // Offset between the camera and the target
    
    // Start is called before the first frame update
    void Start()
    {
        // Calculate the initial offset between the camera and the target
        offset = transform.position - target.position;
    }

    // ensure the camera follows the GameObject's downward movement after the Gameobject has finished updating its position in the current frame
    void LateUpdate()
    {
        // Update the camera's position to follow the target's downward movement
        Vector2 targetPosition = new Vector2(transform.position.x, target.position.y + offset.y);
        transform.position = targetPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float minX = -0.870f;
    public float maxX = 0.870f;
    public float minY = 0.3f;
    public float maxY = 1f;

    private void Update()
    {
        // Get input for movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Invert movement direction
        moveHorizontal = -moveHorizontal;

        // Calculate target position
        Vector3 targetPosition = transform.position + new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;

        // Clamp target position within boundaries
        targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minY, maxY);

        // Move the player
        transform.position = targetPosition;
    }
}


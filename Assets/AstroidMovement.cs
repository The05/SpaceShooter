using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float asteroidSpeed = 5f;

    void Update()
    {
        // Move the asteroid to the left in world space
        transform.Translate(Vector3.right * asteroidSpeed * Time.deltaTime, Space.World);
    }
}

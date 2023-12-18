using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float asteroidSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * asteroidSpeed * Time.deltaTime, Space.World);
    }
}

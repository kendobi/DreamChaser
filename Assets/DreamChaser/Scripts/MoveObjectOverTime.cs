using UnityEngine;

public class MoveObjectOverTime : MonoBehaviour
{
    public float speedX = 1.0f; // Speed along the x-axis
    public float speedY = 0.0f; // Speed along the y-axis
    public float speedZ = 0.0f; // Speed along the z-axis

    void Update()
    {
        // Calculate the movement in each axis based on time and speed
        float moveX = speedX * Time.deltaTime;
        float moveY = speedY * Time.deltaTime;
        float moveZ = speedZ * Time.deltaTime;

        // Move the GameObject
        transform.Translate(new Vector3(moveX, moveY, moveZ));
    }
}

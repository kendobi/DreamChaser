using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Speed at which the GameObject moves up
    public float amplitude = 2.0f; // Amplitude of the sine wave
    public float frequency = 1.0f; // Frequency of the sine wave

    private float initialY;
    private float time = 0.0f;

    void Start()
    {
        initialY = transform.position.y;
    }

    void Update()
    {
        // Move the GameObject up
        Vector3 newPosition = transform.position;
        newPosition.y += moveSpeed * Time.deltaTime;
        transform.position = newPosition;

        // Create a sine wave motion in the x-direction
        time += Time.deltaTime;
        float xPosition = amplitude * Mathf.Sin(frequency * time);
        newPosition.x = xPosition;
        transform.position = newPosition;
    }
}

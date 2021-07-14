using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOverTimeOnce : MonoBehaviour
{

    public Vector3 minScale;
    public Vector3 maxScale;
    public Vector3 ScaleSpeed;

    private Vector3 currentScale;

// Start is called before the first frame update
void Start()
    {
        transform.localScale = minScale;
        currentScale = transform.localScale;
      
    }

    // Update is called once per frame
    void Update()
    {

        if (currentScale.x >= maxScale.x || currentScale.x < minScale.x)
        {
            ScaleSpeed = new Vector3(0.0f, 0.0f, 0.0f);
        }
        else {
            currentScale += ScaleSpeed*Time.deltaTime/100;
            transform.localScale = currentScale;

        } 
    }
}

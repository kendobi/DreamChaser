using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FadeOverTime : MonoBehaviour
{
    private Material mat;
    private float opac;
    private float t = 0.0f;
    private float timeLimit = 1.0f;
    public float speed = 0.1f;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        mat.SetFloat("_opacity", 0.0f);
    }

    void Update()
    {
        if (t < timeLimit)
        {
            // Animate the Shininess value
            //float shininess = Mathf.PingPong(Time.time, 1.0f);
            opac = Mathf.Lerp(0.0f, 1.0f, t);
            mat.SetFloat("_opacity", opac);
            t += speed * Time.deltaTime;
        }
    }
}
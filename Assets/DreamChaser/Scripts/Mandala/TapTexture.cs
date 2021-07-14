using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TapTexture : MonoBehaviour
{
    Renderer rend;
    private float opac;
    public float speedOn = 0.1f;
    public float speedOff = 0.5f;

    private bool isPressed = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        opac = 0.0f;
    }
    void OnMouseOver()
    {
        if (opac <= 1.0f)
        { 
            opac += speedOn * Time.deltaTime;
            rend.material.SetFloat("_opacity", opac);
        }
        isPressed = true;
    }
    void OnMouseExit()
    {
        isPressed = false;
    }

    void Update() {
        if (!isPressed && opac >= 0.0f)
        {
            opac -= speedOff * Time.deltaTime;
            rend.material.SetFloat("_opacity", opac);
        }
    }
}
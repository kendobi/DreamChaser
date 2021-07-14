using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TapFX : MonoBehaviour
{

    private bool isPressed = false;
    public GameObject[] FX;

    void Start()
    {
        
        for (int i = 0; i < FX.Length; i++)
        {
            FX[i].GetComponent<ParticleSystem>().enableEmission = false;
        }
    }
    void OnMouseOver()
    {

        for (int i = 0; i < FX.Length; i++)
        {
            FX[i].GetComponent<ParticleSystem>().enableEmission = true;
        }
        isPressed = true;
    }
    void OnMouseExit()
    {
        isPressed = false;
        for (int i = 0; i < FX.Length; i++)
        {
            FX[i].GetComponent<ParticleSystem>().enableEmission = false;
        }

    }

 
}
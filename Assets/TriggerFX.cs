using UnityEngine;

public class TriggerFX : MonoBehaviour
{
    public GameObject[] objectToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check for a specific tag (e.g., "Player")
        {
            for (int i = 0; i < objectToActivate.Length; i++)
            {
                if (objectToActivate[i] != null)
                {
                    objectToActivate[i].SetActive(true); // Activate the GameObject
                }
                print("TRIGGER FXXX");
            }
           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritEnergySpawner : MonoBehaviour
{
    public GameObject spiritEnergyPrefab;
    public Transform parentTransform;
    public float spawnRate = 2.0f;  // Number of prefabs spawned per second
    public float spawnAreaWidth = 200.0f;
    public float spawnAreaHeight = 400.0f;
    public float prefabLifespan = 5.0f; // Time in seconds before prefab is destroyed

    private float spawnTimer = 0.0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= 1.0f / spawnRate)
        {
            SpawnSpiritEnergy();
            spawnTimer = 0.0f;
        }
    }

    void SpawnSpiritEnergy()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnAreaWidth / 2, spawnAreaWidth / 2),
            parentTransform.position.y,
            Random.Range(-spawnAreaHeight / 2, spawnAreaHeight / 2)
        );

        GameObject spiritEnergy = Instantiate(spiritEnergyPrefab, spawnPosition, Quaternion.identity);

        // Set the parent of the spawned object to the specified parentTransform
        if (parentTransform != null)
        {
            spiritEnergy.transform.SetParent(parentTransform);
        }

        // Destroy the spawned prefab after the specified lifespan
        Destroy(spiritEnergy, prefabLifespan);
    }
}


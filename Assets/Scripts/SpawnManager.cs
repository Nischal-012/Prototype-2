using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnAnimal;
    private float spawnRangeX=15f;
    private float spawnPositionZ=25f;
    private float spawnDelay = 2f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void SpawnRandomAnimal()
	{
        int animalIndex = Random.Range(0, spawnAnimal.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
        Instantiate(spawnAnimal[animalIndex], spawnPosition, spawnAnimal[animalIndex].transform.rotation);
    }
}

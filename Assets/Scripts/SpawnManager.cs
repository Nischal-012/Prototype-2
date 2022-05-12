using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnAnimal;
    private float spawnRangeX=20f;
    private float spawnPositionZ=20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0,spawnAnimal.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
            Instantiate(spawnAnimal[animalIndex],spawnPosition, spawnAnimal[animalIndex].transform.rotation);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangex = 20;
    private float spawnPosZ = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            //generate animal index and spawn loc.

            Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangex, spawnRangex),
                0, spawnPosZ);
            int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
        }
    }
}

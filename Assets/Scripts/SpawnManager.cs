using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn a new enemy
        Instantiate(enemyPrefab, GenerateSpawnPos(), //Create new enemy at random location
            enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPos() 
        //instead of using void (returns nothing) change it to private Vector3 as it returns a Vector3 value (XYZ)
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3 (spawnPosX, spawnPosZ);

        return randomPos;
    }
}

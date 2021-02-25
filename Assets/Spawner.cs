using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float min_X = -4.3f, max_X = 4.3f;
    public GameObject enemyshooterPrefab;
    public float enemySpawnPerSecond = 0.5f;

    public float timer = 2f;

        
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", 1f / enemySpawnPerSecond);
    }

    // Update is called once per frame
    void SpawnEnemies()
    {
        float pos_X = Random.Range(min_X, max_X);
        Vector3 temp = transform.position;
        temp.x = pos_X;

        if(Random.Range(0, 2) > 0)
        {
            Instantiate(enemyshooterPrefab, temp, Quaternion.Euler(0f, 0f, -90f));
        }
        Invoke("SpawnEnemies", 1f / enemySpawnPerSecond);
    }
}

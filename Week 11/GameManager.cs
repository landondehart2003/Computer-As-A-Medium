using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;   // Task 2

    // Start is called before the first frame update
    void Start()
    {
        // Enemy 1: Starts at 1s, spawns every 2s
        InvokeRepeating("CreateEnemyOne", 1, 2);

        // Task 2 (Enemy 2): Starts at 2s, spawns every 4s
        InvokeRepeating("CreateEnemyTwo", 2, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    // Task 2: Create Enemy Two
    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-8f, 8f), 6.5f, 0), Quaternion.identity);
    }
}
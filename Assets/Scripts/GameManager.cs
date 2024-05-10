using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool ongoing = true;
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        int offset = 0;

        for (int i = 0; i < 10; i++)
        {
            offset = (i + 1) * 5;

            SpawnObstacle(offset);
        }

        StartCoroutine(SpawnObstacles(offset + 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void GameOver()
    {
        ongoing = false;
        Debug.Log("Game over!");
    }

    private void SpawnObstacle(float x = 5f)
    {
        Vector3 spawnPosition = new Vector3(x, Random.Range(-3f, 4f), 0f);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }

    private IEnumerator SpawnObstacles(float offset)
    {
        while (ongoing)
        {
            SpawnObstacle(offset);

            yield return new WaitForSeconds(2f);
        }
    }
}

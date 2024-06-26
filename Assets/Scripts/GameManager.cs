using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool ongoing = true;
    public GameObject obstaclePrefab;
    public TMP_Text scoreText;
    private int score = 0;
    public int Score
    {
        get { return score; }
        set
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstacles");
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

    private void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(10f, Random.Range(-2.8f, 4f), 0f);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }

    private IEnumerator SpawnObstacles()
    {
        while (ongoing)
        {
            SpawnObstacle();

            yield return new WaitForSeconds(1.5f);
        }
    }
}

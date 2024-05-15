using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassByPlayer : MonoBehaviour
{
    private GameObject player;
    private bool passed = false;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= player.transform.position.x && !passed && GameManager.ongoing)
        {
            passed = true;
            gameManager.Score++;
        }
    }
}

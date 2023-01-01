using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPoS = new Vector3(25, 0, 0);
    private PlayerController playerControllerScripts;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 4f, 2f);
        playerControllerScripts = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (playerControllerScripts.gameOver==false)
        {
            Instantiate(obstaclePrefab, spawnPoS, obstaclePrefab.transform.rotation);
        }
       
    }
}

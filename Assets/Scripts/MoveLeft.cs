using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (gameObject.CompareTag("Obstacles")&&transform.position.x<-15)
        {
            Destroy(gameObject);
        }
        
    }
}

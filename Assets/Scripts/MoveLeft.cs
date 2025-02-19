using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float leftBound = -5;

    private PlayerController playControllerScript;
    private ScoreManager     scoreControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        scoreControllerScript = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playControllerScript.gameOver == false && scoreControllerScript.score < 30.0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (playControllerScript.gameOver == false && scoreControllerScript.score >= 30.0f)
        {
            float newSpeed = (speed + 20.0f );
            transform.Translate(Vector3.right * Time.deltaTime * newSpeed);
        }
        if (transform.position.z < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

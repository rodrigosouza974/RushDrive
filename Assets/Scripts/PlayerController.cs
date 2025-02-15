using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float horizontalInput;
    public bool gameOver = false ;

    public AudioClip ObstacleCollisionSound;
    private AudioSource playerAudio;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Obstacle")){
            playerAudio.PlayOneShot(ObstacleCollisionSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}

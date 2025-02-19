using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    public float xRange = 8.0f;

    private float horizontalInput;
    public bool gameOver = false ;
    public bool isOnGround = true;

    public AudioClip ObstacleCollisionSound;
    private AudioSource playerAudio;

    public ParticleSystem dirtParticle;
    public ParticleSystem explosionParticle;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);  
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();

        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerAudio.PlayOneShot(ObstacleCollisionSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParticle.Play();
            dirtParticle.Stop();
         }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script implements the controll of the horizontal axis of the player as wal as collision detection.
public class PlayerCtrl : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    public AudioClip explodeSound;

    public float speed = 20;
    public bool gameOver = false;

    private Rigidbody rb;
    private AudioSource playerAudio;
    private float gravityModifier = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();

        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.forward * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }
    }
}

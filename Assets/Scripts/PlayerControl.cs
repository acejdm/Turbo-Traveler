using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public float jumpForce = 20;

    public int jumpCount, jumpCountOG;

    public GameObject spawnPos;

    public Vector3 moveForce;

    public AudioSource audio1;

    public AudioSource drownSound;

    // Use this for initialization
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        audio1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVel = Input.GetAxis("Horizontal");
        float zVel = Input.GetAxis("Vertical");

        Vector3 moveForce = new Vector3(0, 0, 0);
        moveForce.x = xVel * speed;
        moveForce.z = zVel * speed;
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            moveForce.y = jumpForce;
            jumpCount--;
            audio1.Play();
        }

        rb.AddForce(moveForce);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("I have collided with " + other.gameObject.name);
        //if it's a collision, use "gameObject.tag"
        if (other.gameObject.tag == "Floor")
        {
            jumpCount = jumpCountOG;
        }
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Ouch.");
            Destroy(other.collider.gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        //if it's a Collider, just use ".tag"
        if (col.tag == "Respawn")
        {
            //Destroy the game object that the script is attatched to.
            //Destroy(gameObject);
            drownSound.Play();
            transform.position = spawnPos.transform.position;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            rb.constraints = RigidbodyConstraints.None;
        }
       
    }
    public void Jump()
    {
        moveForce.y = jumpForce;
        jumpCount--;
        
    }

    public void SetSpawnPoint(Vector3 newPosition)
    {
        spawnPos.transform.position = newPosition;
    }
}

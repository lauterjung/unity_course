using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 20f;
    float xSpeed;
    Rigidbody2D rigidBody;
    PlayerMovementScript player;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovementScript>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {
        rigidBody.velocity = new Vector2(xSpeed, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

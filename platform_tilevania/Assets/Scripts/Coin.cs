using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int scoreValue = 100;
    bool wasCollected = false;

    // TODO: random audio pitch with proper Audio implementation
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !wasCollected)
        {
            wasCollected = true;
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
            UpdateScore();
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    void UpdateScore()
    {
        FindObjectOfType<GameSession>().AddScore(scoreValue);
    }
}

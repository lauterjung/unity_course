using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCollided;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground") && !hasCollided)
        {
            hasCollided = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke(nameof(ReloadScene), reloadTime);
        }
    }

    void ReloadScene()
    {
        Debug.Log("Finish");
        // FindObjectOfType<PlayerController>().EnableControls();
        SceneManager.LoadScene(0);
    }
}

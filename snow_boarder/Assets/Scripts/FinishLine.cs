using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finishEffect.Play();
            audioSource.Play();
            Invoke(nameof(ReloadScene), reloadTime);
        }
    }

    void ReloadScene()
    {
        Debug.Log("Finish");
        SceneManager.LoadScene(0);
    }
}

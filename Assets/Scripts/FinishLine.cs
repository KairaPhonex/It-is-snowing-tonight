using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem particle; 
    [SerializeField] AudioClip finishSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {   
            particle.Play();
            audioSource.PlayOneShot(finishSound);
            Invoke("ReloadScene", 0.3f);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
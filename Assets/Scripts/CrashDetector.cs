using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioClip crash;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            FindFirstObjectByType<PlayerController>().disableControls();
            particle.Play();
            audioSource.PlayOneShot(crash);
            Invoke("ReloadScene", 0.6f);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

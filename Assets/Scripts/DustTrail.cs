using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trail;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
       private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            trail.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            trail.Stop();
        }
    }
}

using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioClip areaSound;  // Der Sound, der abgespielt werden soll
    private AudioSource audioSource;

    void Start()
    {
        // Sucht die AudioSource des Spielers
        audioSource = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Prüft, ob der Spieler den Bereich betritt
        if (other.CompareTag("Player"))
        {
            audioSource.clip = areaSound;
            audioSource.Play();
        }
    }
}

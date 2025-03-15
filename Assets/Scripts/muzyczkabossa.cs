using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip bossmusic;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bossmusic;  
        audioSource.loop = true; 
        audioSource.playOnAwake = true;
        audioSource.Play(); 
    }
}
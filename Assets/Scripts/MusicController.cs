using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private static MusicController instance = null;
    private AudioSource audio;

    private void Awake()
    {
        if (instance == null)
        { 
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        if (instance == this) return; 
        Destroy(gameObject);
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();

    }

    public void ChangeMusicState()
    {
        if(audio.isPlaying)
            audio.Pause();
        else
        {
            audio.Play();
        }
    }
}

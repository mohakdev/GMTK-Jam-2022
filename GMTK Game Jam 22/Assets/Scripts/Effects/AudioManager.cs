using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("List of sounds Audio Manager can control")]
    public AudioClip[] AudioList;
    static AudioSource MusicPlayer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        MusicPlayer = GetComponent<AudioSource>();
    }
    /// <summary>
    /// Play a sound from sound list in AudioPlayer. Check AudioPlayer Inspector for more detail
    /// </summary>
    /// <param name="SoundIndex">The Index of the sound you want to play from the list. Check AudioPlayer Inspector for more detail</param>
    public static void PlaySound(AudioClip clip)
    {
        try
        {
            MusicPlayer.PlayOneShot(clip);
        }
        catch
        {
            Debug.LogWarning("Error");
        }
    }
}
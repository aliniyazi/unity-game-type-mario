using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControler : MonoBehaviour
{
    AudioSource AudioVeolume;



    private void Awake()
    {
        int numberOfGameSessions = FindObjectsOfType<AudioControler>().Length;
        if (numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        AudioVeolume = GetComponent<AudioSource>();
    }
    public void SetVolume(float volume)
    {
        AudioVeolume.volume = volume;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControler : MonoBehaviour
{
    [SerializeField] AudioSource MusicAudio;
    [SerializeField] Slider slider;
    private float musicvolume = 1f;
    void Start()
    {
        MusicAudio.Play();
        musicvolume = PlayerPrefs.GetFloat("value");
        MusicAudio.volume = musicvolume;
        slider.value = musicvolume;

    }

    // Update is called once per frame
    void Update()
    {
        MusicAudio.volume = musicvolume;
        PlayerPrefs.SetFloat("value", musicvolume);
    }
    public void updateVolume(float volume)
    {
        musicvolume = volume;
    }
    

}

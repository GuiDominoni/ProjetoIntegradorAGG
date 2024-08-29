using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class musicMangaer : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sfxSlider;
    public AudioSource backgroundMusic;

    private const string MasterVolumeKey = "MasterVolume";
    private const string MusicVolumeKey = "MusicVolume";
    private const string SFXVolumeKey = "SFXVolume";

    void Start()
    {
        
        float masterVolume = PlayerPrefs.GetFloat(MasterVolumeKey, 0.5f);
        float musicVolume = PlayerPrefs.GetFloat(MusicVolumeKey, 0.5f);
        float sfxVolume = PlayerPrefs.GetFloat(SFXVolumeKey, 0.5f);
       

       
        audioMixer.SetFloat("Master", masterVolume);
        audioMixer.SetFloat("Music", musicVolume);
        audioMixer.SetFloat("SFX", sfxVolume);

        if (masterSlider != null) masterSlider.value = masterVolume;
        if (musicSlider != null) musicSlider.value = musicVolume;
        if (sfxSlider != null) sfxSlider.value = sfxVolume;

       
        if (backgroundMusic != null)
        {
            backgroundMusic.Play(); 
        }
    }

    public void OnMasterSliderValueChanged(float value)
    {
        
        audioMixer.SetFloat("Master", value);
        PlayerPrefs.SetFloat(MasterVolumeKey, value);
    }

    public void OnMusicSliderValueChanged(float value)
    {
        
        audioMixer.SetFloat("Music", value);
        PlayerPrefs.SetFloat(MusicVolumeKey, value);
    }

    public void OnSFXSliderValueChanged(float value)
    {
            
        audioMixer.SetFloat("SFX", value);
        PlayerPrefs.SetFloat(SFXVolumeKey, value);
    }
}

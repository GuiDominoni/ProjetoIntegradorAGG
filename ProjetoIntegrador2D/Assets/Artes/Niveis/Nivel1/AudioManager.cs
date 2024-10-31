using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public AudioMixer audioMixer;
    public Slider masterSlider;
    public Slider musicSlider;
    public Slider sfxSlider;

    private const string MasterVolumeKey = "MasterVolume";
    private const string MusicVolumeKey = "MusicVolume";
    private const string SFXVolumeKey = "SFXVolume";

    void Awake()
    {
        // Verifica se já existe uma instância do AudioSettingsManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantém o objeto entre as cenas
        }
        else
        {
            Destroy(gameObject); // Destrói o objeto duplicado
        }
    }

    void Start()
    {
        // Carregar e aplicar os valores salvos dos sliders
        float masterVolume = PlayerPrefs.GetFloat(MasterVolumeKey, 0.5f);
        float musicVolume = PlayerPrefs.GetFloat(MusicVolumeKey, 0.5f);
        float sfxVolume = PlayerPrefs.GetFloat(SFXVolumeKey, 0.5f);

        // Aplicar os valores ao mixer
        audioMixer.SetFloat("Master", masterVolume);
        audioMixer.SetFloat("Music", musicVolume);
        audioMixer.SetFloat("SFX", sfxVolume);

        // Configurar os sliders para refletir os valores salvos
        masterSlider.value = masterVolume;
        musicSlider.value = musicVolume;
        sfxSlider.value = sfxVolume;
    }

    public void OnMasterSliderValueChanged(float value)
    {
        // Atualizar o mixer e salvar o valor do slider
        audioMixer.SetFloat("Master", value);
        PlayerPrefs.SetFloat(MasterVolumeKey, value);
    }

    public void OnMusicSliderValueChanged(float value)
    {
        // Atualizar o mixer e salvar o valor do slider
        audioMixer.SetFloat("Music", value);
        PlayerPrefs.SetFloat(MusicVolumeKey, value);
    }

    public void OnSFXSliderValueChanged(float value)
    {
        // Atualizar o mixer e salvar o valor do slider
        audioMixer.SetFloat("SFX", value);
        PlayerPrefs.SetFloat(SFXVolumeKey, value);
    }
}

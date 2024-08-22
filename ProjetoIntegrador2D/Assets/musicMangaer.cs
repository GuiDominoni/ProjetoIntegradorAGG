using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musicMangaer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioMixer mixer;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Master(float master)
    {
        mixer.SetFloat("Master", master);
    }
    public void Music(float music)
    {
        mixer.SetFloat("Music", music);
    }
    public void SFX(float sfx)
    {
        mixer.SetFloat("SFX", sfx);
    }

}

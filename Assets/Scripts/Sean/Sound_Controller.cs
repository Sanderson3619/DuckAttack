using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Sound_Controller : MonoBehaviour {

    public AudioMixer s_AudioMixer;

    public void SetVolume (float volume)
    {
        s_AudioMixer.SetFloat("volume", volume);
    }

    public void BackButton ()
    {
        SceneManager.LoadScene("StartMenu");
    }

}

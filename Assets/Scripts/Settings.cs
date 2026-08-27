using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1f);
        //AudioListener.volume = volumeSlider.value;
        //volumeSlider.value = AudioListener.volume;
        AudioListener.volume = savedVolume;
        volumeSlider.value = savedVolume;

    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
}

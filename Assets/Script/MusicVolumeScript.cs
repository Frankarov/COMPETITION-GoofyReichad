using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicVolumeScript : MonoBehaviour
{

    private void Start()
    {
        if (!PlayerPrefs.HasKey("musicvolume"))
        {
            PlayerPrefs.SetFloat("musicvolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    [SerializeField] private Slider slider;

    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        Save();
    }

    private void Load()
    {
        slider.value = PlayerPrefs.GetFloat("musicvolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicvolume",slider.value);
    }


}

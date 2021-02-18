using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider difficultySlider;

    [SerializeField] float defaultVolume;
    [SerializeField] int defaultDifficulty;

    MusicPlayer musicPlayer;

    private void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
        musicPlayer = FindObjectOfType<MusicPlayer>();
    }

    private void Update()
    {
        musicPlayer.SetVolume(volumeSlider.value);
    }

    public void SetVolume() //acessed by slider
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
    }

    public void SetDifficulty()
    {
        PlayerPrefsController.SetDifficulty(Mathf.RoundToInt(difficultySlider.value));
    }

    public void SetToDefaults() //acessed by button
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }

}
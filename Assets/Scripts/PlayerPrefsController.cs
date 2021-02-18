using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public const int MIN_DIFFICULTY = 1;
    public const int MAX_DIFFICULTY = 5;

    //MASTER VOLUME
    public static void SetMasterVolume(float volume) //by setting to static, it can be acessed by any class without having to be stantiated
    {
        if(volume >= MIN_VOLUME || volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
            Debug.Log(GetMasterVolume());

        }
        else
        {
            Debug.LogError(volume + " is out of range for the master volume");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    //DIFFICULTY
    public static void SetDifficulty(int difficulty)
    {
        if(difficulty >= MIN_DIFFICULTY || difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
            Debug.Log(GetDifficulty());
        }
        else
        {
            Debug.LogError(difficulty + " is out of range for difficulty");
        }
    }

    public static int GetDifficulty()
    {
        return PlayerPrefs.GetInt(DIFFICULTY_KEY);
    }
}
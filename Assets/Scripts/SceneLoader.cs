using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField] float waitingTime = 3f;

    int currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(waitingTime);
        LoadNextScene(); 
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene("Options Screen");
    }

}

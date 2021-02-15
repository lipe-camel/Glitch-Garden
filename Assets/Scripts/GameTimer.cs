using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in SECONDS")]
    [SerializeField] float levelTime = 10;

    Slider slider;
    bool timerFinished = false;
    bool triggeredLevelFinished = false;


    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (triggeredLevelFinished) { return; }
        CheckIfTimerFinished();
    }

    private void CheckIfTimerFinished()
    {
        slider.value = Time.timeSinceLevelLoad / levelTime;
        timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().StopSpawners();
            triggeredLevelFinished = true;
        }
    }

    public bool GetTimerFinished() { return timerFinished; }
}
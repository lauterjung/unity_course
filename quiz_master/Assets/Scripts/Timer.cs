using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timerToCompleteQuestion = 30f;
    [SerializeField] float timerToShowCompleteAnswer = 10f;
    public bool loadNextQuestion;
    public bool isAnsweringQuestion;
    public float fillFraction;

    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timerToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timerToShowCompleteAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timerToShowCompleteAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timerToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}

﻿using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private GameObject mainScene;
    [SerializeField]
    private GameObject endScene;

    private float timeRemaining = 6;
    [SerializeField]
    private Text timeText;

    [SerializeField]
    private collectFruit collectFruit;
    [SerializeField]
    private Text textScore;

    private void Start()
    {
        endScene.SetActive(false);
    }

    void Update()
    {
        TimeDisplay(timeRemaining);
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            mainScene.SetActive(false);
            endScene.SetActive(true);
            textScore.text = collectFruit.counter.ToString();
        }
    }

    void TimeDisplay(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
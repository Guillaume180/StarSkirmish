using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    //This is how we will contril the time for our game.
    public enum TimeState { Tutorial, Unpaused, Countdown, Paused, Gameover, Complete };
    public TimeState state = TimeState.Countdown;

    //If we are going to put a timer in our game.
    public Text timeText;

    public GameObject gameIsOverScreen;
    public GameObject gameIsCompleteScreen;
    public GameObject endOfLevelScreen;
    public GameObject gameIsPauseScreen;
    public GameObject tutorialScreen;

    public int time;

    private void Update()
    {
        switch (state)
        {
            case (TimeState.Tutorial):
                TutorialScreen();
                break;
            case (TimeState.Unpaused):
                UnpauseTheGame();
                break;
            case (TimeState.Countdown):
                CountdownTime();
                break;
            case (TimeState.Paused):
                PauseTheGame();
                break;
            case (TimeState.Gameover):
                GameisOver();
                break;
            case (TimeState.Complete):
                GameIsComplete();
                break;
        }

        if (time <= 0)
        {
            StopCoroutine("LoseTime");
            state = TimeState.Gameover;
        }
    }

    void CountdownTime()
    {
        StartCoroutine("LoseTime");
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time--;
        }
    }

    public void TutorialScreen()
    {
        Time.timeScale = 0;
        tutorialScreen.SetActive(true);
    }

    public void UnpauseTheGame()
    {
        Time.timeScale = 1;
        gameIsPauseScreen.SetActive(false);
        tutorialScreen.SetActive(false);
        state = TimeState.Countdown;
    }

    public void PauseTheGame()
    {
        Time.timeScale = 0;
        gameIsPauseScreen.SetActive(true);
    }

    public void GameisOver()
    {
        Time.timeScale = 0;
        gameIsOverScreen.SetActive(true);
    }

    public void GameIsComplete()
    {
        Time.timeScale = 0;
        gameIsCompleteScreen.SetActive(true);
    }


}

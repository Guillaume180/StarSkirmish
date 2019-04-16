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
    public Slider explosionSilder;

    public GameObject gameIsOverScreen;
    public GameObject gameIsCompleteScreen;
    public GameObject gameIsPauseScreen;
    public GameObject tutorialScreen;

    public float time;
    public float explosion;

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

        timeText.text = time.ToString("F0");
        explosionSilder.value = explosion;
    }

    void CountdownTime()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            explosion += Time.deltaTime;
        }
        else if (time <= 0)
        {
            state = TimeState.Gameover;
        }
    }


    void TutorialScreen()
    {
        Time.timeScale = 0;
        tutorialScreen.SetActive(true);
    }

    void UnpauseTheGame()
    {
        Time.timeScale = 1;
        gameIsPauseScreen.SetActive(false);
        tutorialScreen.SetActive(false);
        state = TimeState.Countdown;
    }

    void PauseTheGame()
    {
        Time.timeScale = 0;
        gameIsPauseScreen.SetActive(true);
    }

    void GameisOver()
    {
        Time.timeScale = 0;
        gameIsOverScreen.SetActive(true);
    }

    void GameIsComplete()
    {
        Time.timeScale = 0;
        gameIsCompleteScreen.SetActive(true);
    }


}

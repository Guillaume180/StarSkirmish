using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    //This is how we will contril the time for our game.
    public enum TimeState {Customisation, Tutorial, Unpaused, Countdown, Paused, Gameover, Complete };
    public TimeState state = TimeState.Countdown;

    //If we are going to put a timer in our game.
    public Text timeText;
    public Slider explosionSilder;

    public GameObject customisationScreen;
    public GameObject tutorialScreen;
    public GameObject gameIsPauseScreen;
    public GameObject gameIsOverScreen;
    public GameObject gameIsCompleteScreen;

    public float time;
    public float explosion;

    public ScoreScript scoreBoard;
    public Text scoreText;
    public int bronzeGoal;
    public GameObject bronzeStar;
    public int silverGoal;
    public GameObject silverStar;
    public int goldGoal;
    public GameObject goldStar;

    private void Start()
    {
        state = TimeState.Customisation;
    }

    private void Update()
    {
        switch (state)
        {
            case (TimeState.Customisation):
                CustomisationScreen();
                break;
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

    void CustomisationScreen()
    {
        Time.timeScale = 0;
        customisationScreen.SetActive(true);

    }

    void TutorialScreen()
    {
        Time.timeScale = 0;
        tutorialScreen.SetActive(true);
    }

    void UnpauseTheGame()
    {
        Debug.Log("Game is resumed");
        Time.timeScale = 1;
        gameIsPauseScreen.SetActive(false);
        tutorialScreen.SetActive(false);
        customisationScreen.SetActive(false);
        state = TimeState.Countdown;
    }

    void PauseTheGame()
    {
        Debug.Log("Game is paused");
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

        scoreText.text = scoreBoard.score.ToString();

        if(scoreBoard.score >= bronzeGoal)
        {
            bronzeStar.SetActive(true);
        }
        if (scoreBoard.score >= silverGoal)
        {
            silverStar.SetActive(true);
        }
        if (scoreBoard.score >= goldGoal)
        {
            goldStar.SetActive(true);
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{

    public TimerScript timeState;

    //Simple script to make the button select certain levels.
    public void ChangeTheScene(int SceneNumber)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneNumber);
    }

    public void ResmueTheGame()
    {
        Debug.Log("Resume the game");
        Time.timeScale = 1;
        timeState.state = TimerScript.TimeState.Unpaused;
    }

    public void RestartTheGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseTheGame()
    {
        Time.timeScale = 1;
        timeState.state = TimerScript.TimeState.Paused;
    }

    public void QuitTheGame()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}

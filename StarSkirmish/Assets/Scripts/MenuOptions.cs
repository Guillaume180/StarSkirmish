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
        timeState.state = TimerScript.TimeState.Unpaused;
    }

    public void PauseTheGame()
    {
        timeState.state = TimerScript.TimeState.Paused;
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }
}

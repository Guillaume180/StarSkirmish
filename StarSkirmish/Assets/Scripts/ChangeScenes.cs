using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    //Simple script to make the button select certain levels.
    public void ChangeTheScene(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}

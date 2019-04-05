using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelSelect : MonoBehaviour
{
    public void loadLevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}

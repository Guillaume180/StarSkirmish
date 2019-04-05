using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void LoadMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadStore()
    {
        SceneManager.LoadScene("Store");
    }

    public void LoadWorlds()
    {
        SceneManager.LoadScene("WorldSelect");
    }

    public void LoadProfile()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WorldScene : MonoBehaviour
{
    public void loadWorldScene()
    {
        SceneManager.LoadScene("WorldSelect");
    }
}

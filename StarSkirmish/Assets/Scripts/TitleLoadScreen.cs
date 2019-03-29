using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleLoadScreen : MonoBehaviour
{
    public Slider loadingSlider;

    public int loadingTimer = 0;

    public int refreshLoadTime = 0;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            loadingTimer++;
            if (loadingTimer >= 5)
            {
                StopCoroutine("LoseTime");
                loadingTimer = refreshLoadTime;
                StartGame();
            }
        }

    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        loadingSlider.value = loadingTimer;
    }
}

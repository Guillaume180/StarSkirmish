using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int scoreBlocks;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.x.ToString("0");
        //scoreText.text = scoreBlocks.ToString();
    }
}

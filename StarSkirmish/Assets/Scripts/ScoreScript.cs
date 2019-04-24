using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float scoreBlocks;
    public float score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("0");
        score = scoreBlocks + player.position.x;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public GameObject isBird;
    public GameObject isSpawnPipe;
    public int highScore;
    public Text highScoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore >= highScore )
        {
            highScore = playerScore;
            highScoreText.text = scoreText.text;
        }
    }

    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void startGame() 
    {
        gameStartScreen.SetActive(false);
        isBird.SetActive(true);
        isSpawnPipe.SetActive(true);
    }
}

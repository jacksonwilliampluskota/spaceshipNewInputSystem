using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public Sprite[] lives;
    public Image livesImageDisplay;
    public Text ScoreText;
    public int score = 0;
    public Text bestScoreText;
    private int _bestScore = 0;
    public GameObject titleScreen;

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "Best: " + _bestScore;
    }

    public void UpdatLives(int livesPlayer)
    {
        livesImageDisplay.sprite = lives[livesPlayer];
    }

    public void UpdateScore()
    {
        score += 10;
        ScoreText.text = "Score: " + score;
    }
    public void CheckBestScore()
    {
        if (score > _bestScore)
        {
            _bestScore = score;
            PlayerPrefs.SetInt("BestScore", _bestScore);
            bestScoreText.text = "Best: " + _bestScore;
        }
    }
    public void ShowTitleScreen()
    {
        titleScreen.SetActive(true);
    }

    public void HideTitelScreen()
    {
        score = 0;
        ScoreText.text = "Score: 0";
        titleScreen.SetActive(false);
    }

    public void ResumePlay()
    {
        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (gm != null)
        {
            gm.ResumePlay();
        }
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_menu");
    }
}

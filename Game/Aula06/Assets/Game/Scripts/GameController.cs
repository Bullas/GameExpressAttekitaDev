using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private bool isGameRunning;
    private int score;

    public ObstacleGenerator generator;
    public GameConfiguration config;
    public TextMeshProUGUI scoreLabel;
    public GameUI gameStartUI;
    public GameUI gameOverUI;
    public Player player;

    void Start()
    {
        isGameRunning = false;

        gameStartUI.Show();
    }

    private void Update()
    {
        scoreLabel.text = score.ToString("000000000.##");

        if (!isGameRunning) return;
        score++;
    }

    public void GameStart()
    {
        isGameRunning = true;

        config.speed = 4f;
        generator.GenerateObstacles();
        score = 0;
        gameStartUI.Hide();
        player.SetActive();
        

    }

    public void GameOver()
    {
        print("o jogo acabou!");

        isGameRunning = false;

        config.speed = 0f;
        generator.StopGenerator();
        gameOverUI.Show();

    }


}

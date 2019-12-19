using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isGameRunning;

    public ObstacleGenerator generator;
    public GameConfiguration config;

    void Start()
    {
        isGameRunning = false;

        GameStart();
    }

    void GameStart()
    {
        isGameRunning = true;

        config.speed = 4f;
        generator.GenerateObstacles();

    }

    public void GameOver()
    {
        print("o jogo acabou!");

        isGameRunning = false;

        config.speed = 0f;
        generator.StopGenerator();

    }


}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public void LosseHealth()
    {
        lives--;
        
        if (lives <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
        else
        {
            ResetLevel();
        }

    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }
}

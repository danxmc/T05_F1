﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private static LevelManager instance = null;

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        if (name == "Menu")
        {
            ScoreKeeper.Reset();
        }
        SceneManager.LoadScene(name);
    }

    public void EndGame()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Allows use of GameManager varibles/functions outside of the GameManager script
    public static GameManager instance;

    //Scene number to change
    public int currentScene = 0;

    //Score showing number of coins collected
    public int playerScore = 0;

    //Destroy second GameManager if there is one
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("Warning: A second Game Manager was detected and destroyed.");
        }
    }

    //Next 3 functions change the scene

    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
        //Potentially dangerous
        currentScene++;
    }

    public void LoadLevel(int indexToLoad)
    {
        SceneManager.LoadScene(indexToLoad);
        currentScene = indexToLoad;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

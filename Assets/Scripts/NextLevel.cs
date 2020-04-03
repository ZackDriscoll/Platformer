using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //Current scene to change
    public int currentScene = 0;

    //Swap to next scene
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LoadVictory();
        }
    }

    //Loads the Victory Scene
    public void LoadVictory()
    {
        SceneManager.LoadScene(currentScene += 3);
    }
}

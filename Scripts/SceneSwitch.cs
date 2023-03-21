using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    //creates a string for which scene to switch to
    [SerializeField]
    private string scene;


    //switch to a specified scene if gameobject is collided with
    private void OnTriggerEnter2D(Collider2D other)
    {
        //loads specified scene
        SceneManager.LoadScene(scene);

    }

    //for button clicks

    //switch to first scene
    public void sceneSwitchTo1()
    {
        SceneManager.LoadScene("ToLevel1");
    }

    //switch to victory scene
    public void sceneChangeToVictory()
    {
        SceneManager.LoadScene("Victory");
    }

    //switch to death scene
    public void sceneChangeToDeath()
    {
        SceneManager.LoadScene("Death");
    }

    //switch to story1 scene
    public void sceneChangeToStory1()
    {
        SceneManager.LoadScene("Story1");
    }

    //switch to scene called HomeBase
    public void sceneChangeToStart()
    {
        SceneManager.LoadScene("HomeBase");
    }
    //switch to scene called Instructions1
    public void sceneChangeToInstructions1()
    {
        SceneManager.LoadScene("Instructions1");
    }
    //switch to scene called Instructions2
    public void sceneChangeToInstructions2()
    {
        SceneManager.LoadScene("Instructions2");
    }
    //switch to scene called Menu
    public void sceneChangeToTitle()
    {
        SceneManager.LoadScene("Main Menu");
    }
    //switch to scene called HighScores
    public void sceneChangeToScore()
    {
        SceneManager.LoadScene("HighScores");
    }

    //quits the game 
    public void endGame()
    {
        Application.Quit();
    }

}

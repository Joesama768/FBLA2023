using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class gameManager : MonoBehaviour
{
    [SerializeField] private int levelNum;
    //sets varibles to show score in game
    [SerializeField] private int currentScore;
    [SerializeField]  TextMeshProUGUI scoreText;

    //text to show lives 
    [SerializeField] TextMeshProUGUI livesText;

    //sets global variables
    public static gameManager Instance { get; private set; }
    public static int score = 0;
    public static int lives = 3;


    private void Start()
    {
        DontDestroy[] bgms = FindObjectsOfType<DontDestroy>();
        foreach (DontDestroy bgm in bgms)
        {
            if(bgm.BgmLevelNum != levelNum)
            {
                Destroy(bgm.gameObject);
            }
        }
    }

    //checks to see if the user has press escape every frame
    void Update()
    {
        //if escape is pressed, quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //sets the displayed score to the score in the gameManager
        scoreText.text = ("Score: " + score.ToString());
        livesText.text = ("Lives: " + lives.ToString());
    }

    public void resetGame()
    { 
        //resets number of lives
        lives = 3;
        score = 0;
    }
}

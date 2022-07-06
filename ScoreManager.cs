using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreBoard;
    public Text highScore;
   // public GameO
    public static int theScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        scoreBoard.GetComponent<Text>().text = "Score: " + theScore; 
        
        if (theScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", theScore);
            highScore.text = theScore.ToString();
        }

    }
}


